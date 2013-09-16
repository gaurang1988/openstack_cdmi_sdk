using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccessfulAuthorization()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            Assert.AreEqual(true, client.getAuthorizationToken());
        }

        [TestMethod]
        public void UnSuccessfulAuthorization()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("121.223.222.222","admin","admin","admin");
            Assert.AreEqual(false,client.getAuthorizationToken());
        }

        [TestMethod]
        public void CreateContainer()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            Assert.AreEqual(true,handler.createContainer("TestContainer"));
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void DeleteContainer()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            handler.createObject("TestConrttainer","TestObject","D:/TestFolder/childObject.txt");
            handler.createObject("TestContainer","TestObject2","D:/TestFolder/childObject.txt");
            handler.createContainer("adasdad");
            Assert.AreEqual(true, handler.deleteContainer("TestContainer"));
        }

        [TestMethod]
        public void CreateObject()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            //client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            //handler.createContainer("TestContainer");
            Assert.AreEqual(false, handler.createObject("Purnima_Gawande","TestObject","K:/TestFolder/childObject.txt"));
            //handler.deleteObject("TestContainer", "TestObject");
            //handler.deleteContainer("TestContainer");
        }



        [TestMethod]
        public void DeleteObject()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            handler.createObject("TestContainer", "TestObject", "D:/TestFolder/childObject.txt");
            Assert.AreEqual(true, handler.deleteObject("TestContainer", "TestObject"));
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void GetContainer()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            //handler.createContainer("TestContainer");
            ObjectStoreSDK.Container container = handler.getContainer("TestContaioo");
            Assert.AreEqual(false, container.isGetSuccessful());
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void CreateChildContainer()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            ObjectStoreSDK.Container container = handler.getContainer("TestContainer");
            Assert.AreEqual(true,container.createChildContainer("TestChildContainer"));
            container.deleteChildContainer("TestChildContainer");
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void DeleteChildContainer()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            ObjectStoreSDK.Container container = handler.getContainer("TestContainer");
            container.createChildContainer("TestChildContainer");
            container = container.getChildContainer("TestChildContainer");
            container.createChildObject("TestChildObject","D:/TestFolder/childObject.txt");
            container = container.getParentContainer();
            Assert.AreEqual(true, container.deleteChildContainer("TestChildContainer"));
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void CreateChildObject()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            ObjectStoreSDK.Container container = handler.getContainer("TestContainer");
            Assert.AreEqual(true,container.createChildObject("TestChildObject","D:/TestFolder/childObject.txt"));
            container.deleteChildObject("TestChildObject");
            handler.deleteContainer("TestContainer");
        }

        [TestMethod]
        public void DeleteChildObject()
        {
            ObjectStoreSDK.Client client = new ObjectStoreSDK.Client("192.168.43.8", "admin", "admin", "admin");
            client.getAuthorizationToken();
            ObjectStoreSDK.Handler handler = client.getHandler();
            handler.createContainer("TestContainer");
            ObjectStoreSDK.Container container = handler.getContainer("TestContainer");
            container.createChildObject("TestChildObject", "D:/TestFolder/childObject.txt");
            Assert.AreEqual(true,container.deleteChildObject("TestChildObject") );
            handler.deleteContainer("TestContainer");
        }


    }
}
