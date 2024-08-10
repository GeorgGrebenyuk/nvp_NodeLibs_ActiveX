﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using NVP_Manifest_Creator;
using System.Collections;

namespace List
{
    [NVP_Manifest(
        Text = "Делает выборку из списка для сравниваемого объекта, если режим = true, то ищется прямое соответствие, если false -- то частичное (только для строк). Если Режим возврата = true, то вернутся только позиции удовлетворяющие запросы, если false -- то не удовлетворяющие",
        ViewType = "Modifier")]
    [NodeInput("Исходный список", typeof(object))]
    [NodeInput("Сравниваемый объект", typeof(object))]
    [NodeInput("Режим сравнения строк", typeof(bool))]
    [NodeInput("Режим возврата", typeof(bool))]
    public class FilterByCondition : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            List<object> items = inputs[0].Value as List<object>;
            List<bool> results = new List<bool>();

            object comparing_object = inputs[1].Value;
            bool comparing_mode = (bool)inputs[2].Value;
            bool return_data = (bool)inputs[3].Value;

            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                bool result = false;
                if (item != null)
                {
                    //bool can_add = false;
                    if (item.GetType().Equals(typeof(string)))
                    {
                        if (comparing_mode && item.ToString() == comparing_object.ToString()) result = true;
                        else if (!comparing_mode && item.ToString().Contains(comparing_object.ToString())) result = true;
                    }
                    else if (item.Equals(comparing_object)) result = true;

                    
                }

                if (!return_data) result = !result;
                results.Add(result);
            }

            return new NodeResult(results); ;
        }
    }

    [NVP_Manifest(
            Text = "Делает выборку из списка по заданной маске (одноразмерному списку bool)",
            ViewType = "Modifier")]
    [NodeInput("Исходный список", typeof(object))]
    [NodeInput("Маска", typeof(List<bool>))]
    public class FilterByBoolMask : INode 
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            IList items = (IList)inputs[0].Value;
            List<bool> mask = inputs[1].Value as List<bool>;

            List<object> results = new List<object>();

            for (int i = 0; i < items.Count; i++)
            {
                if (mask[i]) results.Add(items[i]);
            }

            return new NodeResult(results); ;
        }
    }



}
