#!/bin/bash -e

cd $TRAVIS_BUILD_DIR

readonly package_names=(
    "resilient"
    "resilient-circuits"
    "resilient-sdk"
    "resilient-lib"
    "pytest-resilient-circuits"
    "rc-cts"
    "rc-webserver"
)

# Write the version as environment variable.
export SETUPTOOLS_SCM_PRETEND_VERSION=$NEW_VERSION

for p in "${package_names[@]}"; do
    # Get directory of package
    dir=$(echo $TRAVIS_BUILD_DIR/$p)
    echo "Building source distribution of $dir"

    # Remove any old dist files.
    rm -rf $dir/dist/*

    # Build the source distribution.
    (cd $dir && python setup.py sdist --formats=gztar)

    # Append path to sdist to PATHS_TO_COPY_TO_ARTIFACTORY array
    sdist_path=$(ls $dir/dist/*.tar.gz)
    echo "Path to sdist: $sdist_path"
    PATHS_TO_COPY_TO_ARTIFACTORY+=($sdist_path)

done
