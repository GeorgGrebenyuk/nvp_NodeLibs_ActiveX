﻿using NVP.API.Nodes;

namespace Renga.EquipmentStyleManager 
{
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyleManager_Constructor : INode 
	{
		public Renga.IEquipmentStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IEquipmentStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyleManager_ConstructorCast : INode 
	{
		public Renga.IEquipmentStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IEquipmentStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("EquipmentStyleManager", typeof(object))]
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("EquipmentStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1]));

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("EquipmentStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]
	public class GetEquipmentStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEquipmentStyle(inputs[1]));

		}
	}
}
