﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ModelObject 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObject_Constructor : INode 
	{
		public Renga.IModelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IModelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ModelObject_ConstructorCast : INode 
	{
		public Renga.IModelObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IModelObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ObjectType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectType);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProperties);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetQuantities : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetQuantities);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("ModelObject", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ObjectTypeS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectTypeS);

		}
	}
}
