﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for the collection of all mline styles in the drawing
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaMLineStyles 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyles_Constructor : INode 
	{
		public OdaX.IOdaMLineStyles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaMLineStyles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyles_ConstructorCast : INode 
	{
		public OdaX.IOdaMLineStyles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaMLineStyles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyles", typeof(object))]
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
	[NodeInput("OdaMLineStyles", typeof(object))]

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
	[NodeInput("OdaMLineStyles", typeof(object))]
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
}
