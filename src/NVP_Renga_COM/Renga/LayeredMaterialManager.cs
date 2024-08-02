﻿using NVP.API.Nodes;

namespace Renga.LayeredMaterialManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_Constructor : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("LayeredMaterialIdGroupPair", typeof(System.Object))]
	public class GetLayeredMaterialByIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterialByIdGroupPair(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class GetLayeredMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterial(inputs[1]));

		}
	}
}
