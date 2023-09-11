//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void TheSteps()
        {
            
            List<string> steps = new List<string>();
            foreach (Step step in this.steps)
            {
                steps.Add($"{step.Quantity} de '{step.Input.Description}' " +
                $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            
        }
    }
}