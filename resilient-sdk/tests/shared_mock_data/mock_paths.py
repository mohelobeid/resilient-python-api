#!/usr/bin/env python
# -*- coding: utf-8 -*-
# (c) Copyright IBM Corp. 2010, 2019. All Rights Reserved.

import os

SHARED_MOCK_DATA_DIR = os.path.dirname(os.path.realpath(__file__))
TESTS_DIR = os.path.dirname(SHARED_MOCK_DATA_DIR)

TEST_TEMP_DIR = os.path.join(TESTS_DIR, "test_temp")
