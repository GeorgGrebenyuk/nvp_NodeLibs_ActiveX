﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IPropsDiaWrap Interface
///</summary>
namespace NVP_ModelStudio_COM._mstHVACCOMLib.PropsDiaWrap 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_Constructor : INode 
	{
		public mstHVACCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mstHVACCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class PropsDiaWrap_ConstructorCast : INode 
	{
		public mstHVACCOMLib.IPropsDiaWrap _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mstHVACCOMLib.IPropsDiaWrap;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
}
