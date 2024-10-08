﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ISymSpdsPosition mark
///</summary>
namespace NVP_nanoCAD_COM._McCOM2.SymSpdsPosition 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPosition_Constructor : INode 
	{
		public McCOM2.ISymSpdsPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymSpdsPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymSpdsPosition_ConstructorCast : INode 
	{
		public McCOM2.ISymSpdsPosition _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymSpdsPosition;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "0x000004a5", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPosition", typeof(object))]

	///<summary>
	///0x000004a5
	///</summary>
	public class Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Text);

		}
	}


	[NVP_Manifest(
		Text = "0x000004a5", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPosition", typeof(object))]
	[NodeInput("pvValue", typeof(System.String))]

	///<summary>
	///0x000004a5
	///</summary>
	public class Set_Text : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Text = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004a6", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPosition", typeof(object))]

	///<summary>
	///0x000004a6
	///</summary>
	public class TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextPosition);

		}
	}


	[NVP_Manifest(
		Text = "0x000004a6", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPosition", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004a6
	///</summary>
	public class Set_TextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x000004a3", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPosition", typeof(object))]

	///<summary>
	///0x000004a3
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "0x000004a3", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPosition", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000004a3
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "0x00000497", 
		ViewType = "Data")]
	[NodeInput("SymSpdsPosition", typeof(object))]

	///<summary>
	///0x00000497
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Text = "0x00000497", 
		ViewType = "Modifier")]
	[NodeInput("SymSpdsPosition", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x00000497
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}
}
