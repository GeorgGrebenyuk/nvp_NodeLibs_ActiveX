﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all linetypes in the drawing
///</summary>
namespace OdaX.AcadLineTypes 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLineTypes_Constructor : INode 
	{
		public OdaX.IAcadLineTypes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLineTypes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLineTypes_ConstructorCast : INode 
	{
		public OdaX.IAcadLineTypes _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLineTypes;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in a collection.", 
		ViewType = "Data")]
	[NodeInput("AcadLineTypes", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in a collection.
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
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadLineTypes", typeof(object))]

	///<summary>
	///Returns the number of items in the collection.
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
		Text = "Creates an object and adds it to the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadLineTypes", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates an object and adds it to the collection.
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
		Text = "Loads and makes available a linetype from an LIN file.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLineTypes", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("FileName", typeof(System.String))]

	///<summary>
	///Loads and makes available a linetype from an LIN file.
	///</summary>
	public class Load : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Load(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
