﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimToleranceJustify 
{


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolBottom);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolMiddle);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimToleranceJustify.acTolTop);

		}
	}
}
