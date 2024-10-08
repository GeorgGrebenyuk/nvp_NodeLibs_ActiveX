﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.WallContour 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallContour_Constructor : INode 
	{
		public Renga.IWallContour _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IWallContour;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WallContour_ConstructorCast : INode 
	{
		public Renga.IWallContour _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IWallContour;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenterLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenterLine);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBaseline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBaseline);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLeftCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeftCurve);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRightCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRightCurve);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBeginCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeginCurve);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEndCurve : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEndCurve);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("WallContour", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetContour : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetContour);

		}
	}
}
