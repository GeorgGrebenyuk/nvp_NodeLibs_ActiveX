﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The collection of all selection sets in the drawing
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADSelectionSets 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSets_Constructor : INode 
	{
		public nanoCAD.InanoCADSelectionSets _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADSelectionSets;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSets_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADSelectionSets _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADSelectionSets;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSets", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSets", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Text = "Creates a member object and adds it to the appropriate collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSets", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates a member object and adds it to the appropriate collection
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSets", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все Наборы выбора в виде nanoCAD.nanoCADSelectionSet",
        ViewType = "Data")]
    [NodeInput("nanoCADSelectionSets", typeof(object))]
    public class GetAll_SelectionSets : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as nanoCAD.InanoCADSelectionSets;
            List<_nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_Constructor> items = new List<_nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_Constructor>();
            for (int item_counter = 0; item_counter < _input0.Count; item_counter++)
            {
                _nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_Constructor item = new _nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_Constructor();
                item._i = _input0[item_counter];
                items.Add(item);
            }
            return new NodeResult(items);

        }
    }
}
