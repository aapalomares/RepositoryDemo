﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework; 

namespace ClassLibrary
 {
 [TestFixture]
 public class NUnitTestClass
 { 

[TestFixtureSetUp]
 public void SetupMethods()
 {
 } 

[TestFixtureTearDown]
 public void TearDownMethods()
 {
 } 



[SetUp]
 public void SetupTest()
 {
 } 

[TearDown]
 public void TearDownTest()
 {
 }
 

[Test]
 public void MyTest()
 {
 } 

}
 }
