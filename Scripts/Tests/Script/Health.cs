using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace com.Daniela.HealthTDD
{
    public class Health : MonoBehaviour
    {
        private int life  = 2;
        private int currentValue;
        private Slider bar;
        public int CurrentValue { get; set; }


        public Slider Bar { get; set; }
        public int Life { get; set; }
   
    
        void Start()
        {
            Bar = GetComponentInChildren<Slider>();
          
           
           
        }

        // Update is called once per frame
        void Update()
        {
            Inputs();
           
           
        }

        public int TakeDamage()
        {
            Life = Life - 1;
          
            return life;
        }
        public int RecoverLife()
        {
            Life = Life + 1;
            return Life;
        }

        public int UpdateBar(int lf)
        {
            currentValue = lf;

            return currentValue;
        }

        public void Inputs()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                TakeDamage(); // sub life
                UpdateBar(Life); // get current value 
                Bar.value = currentValue; // bar.value assignment
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                RecoverLife();//add life
                UpdateBar(Life);//get current value
                Bar.value = currentValue; // bar.value assignment
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Health health &&
                   base.Equals(obj) &&
                   EqualityComparer<Slider>.Default.Equals(bar, health.bar);
        }
    }

}