﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_nanoCAD_COM._OdaX.enum_AcMenuFileType 
{


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMenuFileCompiled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuFileType.acMenuFileCompiled);

		}
	}


	[NVP_Manifest(
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMenuFileSource : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcMenuFileType.acMenuFileSource);

		}
	}
}
