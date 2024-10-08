﻿using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///A group of one or more objects specified for processing as a single unit
///</summary>
namespace NVP_nanoCAD_COM._nanoCAD.nanoCADSelectionSet 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSet_Constructor : INode 
	{
		public nanoCAD.InanoCADSelectionSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADSelectionSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSet_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADSelectionSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADSelectionSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
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
	[NodeInput("nanoCADSelectionSet", typeof(object))]

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
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Text = "Sets the highlight status for the given object, or for all objects in a given selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Sets the highlight status for the given object, or for all objects in a given selection set
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Erases all the objects in a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Erases all the objects in a selection set
	///</summary>
	public class Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Erase();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Updates the object to the drawing screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Updates the object to the drawing screen
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Text = "Adds one or more objects to the specified selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("pSelSet", typeof(System.Object))]

	///<summary>
	///Adds one or more objects to the specified selection set
	///</summary>
	public class AddItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Removes specified items from the group or selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Removes specified items from the group or selection set
	///</summary>
	public class RemoveItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Clears the specified selection set of all items", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Clears the specified selection set of all items
	///</summary>
	public class Clear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clear();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Selects objects and places them into a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("nanoCAD.AcSelect", typeof(System.Object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects objects and places them into a selection set
	///</summary>
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Select(((nanoCAD.AcSelect)inputs[1].Value),inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Selects an object passing through a given point and places it into a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects an object passing through a given point and places it into a selection set
	///</summary>
	public class SelectAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectAtPoint(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Selects entities within a fence and adds them to the selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("nanoCAD.AcSelect", typeof(System.Object))]
	[NodeInput("PointsList", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects entities within a fence and adds them to the selection set
	///</summary>
	public class SelectByPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectByPolygon(((nanoCAD.AcSelect)inputs[1].Value),inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Prompts the user to pick an object from the screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Prompts the user to pick an object from the screen
	///</summary>
	public class SelectOnScreen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectOnScreen(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Deletes a specified object
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Calculates the bounding box of selection", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("MinPoint", typeof(System.Object))]
	[NodeInput("MaxPoint", typeof(System.Object))]

	///<summary>
	///Calculates the bounding box of selection
	///</summary>
	public class GetBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBoundingBox(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
