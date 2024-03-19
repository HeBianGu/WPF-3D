using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeCenters
	/// </summary>
	/// <remarks>
	///    generate points at center of edges
	///
	/// vtkEdgeCenters is a filter that takes as input any graph and
	/// generates on output points at the center of the cells in the dataset.
	/// These points can be used for placing glyphs (vtkGlyph3D) or labeling
	/// (vtkLabeledDataMapper). (The center is the parametric center of the
	/// cell, not necessarily the geometric or bounding box center.) The edge
	/// attributes will be associated with the points on output.
	///
	/// @warning
	/// You can choose to generate just points or points and vertex cells.
	/// Vertex cells are drawn during rendering; points are not. Use the ivar
	/// VertexCells to generate cells.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGlyph3D vtkLabeledDataMapper
	/// </seealso>
	// Token: 0x0200067A RID: 1658
	public class vtkEdgeCenters : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011D99 RID: 73113 RVA: 0x0018F9CB File Offset: 0x0018DBCB
		static vtkEdgeCenters()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeCenters.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeCenters"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011D9A RID: 73114 RVA: 0x0018F9F3 File Offset: 0x0018DBF3
		public vtkEdgeCenters(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011D9B RID: 73115
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeCenters_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x06011D9C RID: 73116 RVA: 0x0018FA04 File Offset: 0x0018DC04
		public new static vtkEdgeCenters New()
		{
			vtkEdgeCenters result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with vertex cell generation turned off.
		/// </summary>
		// Token: 0x06011D9D RID: 73117 RVA: 0x0018FA58 File Offset: 0x0018DC58
		public vtkEdgeCenters() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEdgeCenters.vtkEdgeCenters_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011D9E RID: 73118 RVA: 0x0018FA9C File Offset: 0x0018DC9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011D9F RID: 73119
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeCenters_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DA0 RID: 73120 RVA: 0x0018FAA8 File Offset: 0x0018DCA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011DA1 RID: 73121
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeCenters_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DA2 RID: 73122 RVA: 0x0018FAC8 File Offset: 0x0018DCC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011DA3 RID: 73123
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeCenters_GetVertexCells_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells.
		/// </summary>
		// Token: 0x06011DA4 RID: 73124 RVA: 0x0018FAE4 File Offset: 0x0018DCE4
		public virtual int GetVertexCells()
		{
			return vtkEdgeCenters.vtkEdgeCenters_GetVertexCells_03(base.GetCppThis());
		}

		// Token: 0x06011DA5 RID: 73125
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeCenters_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DA6 RID: 73126 RVA: 0x0018FB04 File Offset: 0x0018DD04
		public override int IsA(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011DA7 RID: 73127
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeCenters_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DA8 RID: 73128 RVA: 0x0018FB24 File Offset: 0x0018DD24
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_IsTypeOf_05(type);
		}

		// Token: 0x06011DA9 RID: 73129
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeCenters_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DAA RID: 73130 RVA: 0x0018FB40 File Offset: 0x0018DD40
		public new vtkEdgeCenters NewInstance()
		{
			vtkEdgeCenters result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011DAB RID: 73131
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeCenters_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DAC RID: 73132 RVA: 0x0018FB9C File Offset: 0x0018DD9C
		public new static vtkEdgeCenters SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeCenters vtkEdgeCenters = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeCenters = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeCenters.Register(null);
				}
			}
			return vtkEdgeCenters;
		}

		// Token: 0x06011DAD RID: 73133
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeCenters_SetVertexCells_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of vertex cells.
		/// </summary>
		// Token: 0x06011DAE RID: 73134 RVA: 0x0018FC1B File Offset: 0x0018DE1B
		public virtual void SetVertexCells(int _arg)
		{
			vtkEdgeCenters.vtkEdgeCenters_SetVertexCells_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06011DAF RID: 73135
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeCenters_VertexCellsOff_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells.
		/// </summary>
		// Token: 0x06011DB0 RID: 73136 RVA: 0x0018FC2B File Offset: 0x0018DE2B
		public virtual void VertexCellsOff()
		{
			vtkEdgeCenters.vtkEdgeCenters_VertexCellsOff_10(base.GetCppThis());
		}

		// Token: 0x06011DB1 RID: 73137
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeCenters_VertexCellsOn_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of vertex cells.
		/// </summary>
		// Token: 0x06011DB2 RID: 73138 RVA: 0x0018FC3A File Offset: 0x0018DE3A
		public virtual void VertexCellsOn()
		{
			vtkEdgeCenters.vtkEdgeCenters_VertexCellsOn_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001499 RID: 5273
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeCenters";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149A RID: 5274
		public new static readonly string MRClassNameKey = "class vtkEdgeCenters";
	}
}
