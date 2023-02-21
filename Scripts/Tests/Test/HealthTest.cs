using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace com.Daniela.HealthTDD
{
    public class HealthTest
    {

        #region TEST IF THE LIFE CAN BE SUBTRACTED
            [Test]
            public void TakeDamage_Test()
            {
                var health = new Health();

               



                health.Life = 10;
                health.TakeDamage();



                Assert.AreEqual(health.Life, 9);


            }

        #endregion


      
        #region TEST IF THE LIFE CAN BE RECOVERED
            [Test]
            public void RecoverLife_Test()
            {
                var health = new Health();
                health.Life = 1;
                health.RecoverLife();
                Assert.AreEqual(health.Life, 2);
            }

        #endregion


        #region TEST IF CURRENT VALUE  GET ASSIGNMENT

        [Test]
        public void UpdateBar_Test()
        {

            var health = new Health();

            health.UpdateBar(3);
           
            Assert.AreEqual(health.UpdateBar(3), 3);

        }
        #endregion



    }
}
