using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphToPolyData
	/// </summary>
	/// <remarks>
	///    convert a vtkGraph to vtkPolyData
	///
	///
	/// Converts a vtkGraph to a vtkPolyData.  This assumes that the points
	/// of the graph have already been filled (perhaps by vtkGraphLayout),
	/// and converts all the edge of the graph into lines in the polydata.
	/// The vertex data is passed along to the point data, and the edge data
	/// is passed along to the cell data.
	///
	/// Only the owned graph edges (i.e. edges with ghost level 0) are copied
	/// into the vtkPolyData.
	/// </remarks>
	// Token: 0x0200082C RID: 2092
	public class vtkGraphToPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015A42 RID: 88642 RVA: 0x001E8DBE File Offset: 0x001E6FBE
		static vtkGraphToPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphToPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015A43 RID: 88643 RVA: 0x001E8DE6 File Offset: 0x001E6FE6
		public vtkGraphToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015A44 RID: 88644
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A45 RID: 88645 RVA: 0x001E8DF4 File Offset: 0x001E6FF4
		public new static vtkGraphToPolyData New()
		{
			vtkGraphToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A46 RID: 88646 RVA: 0x001E8E48 File Offset: 0x001E7048
		public vtkGraphToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphToPolyData.vtkGraphToPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015A47 RID: 88647 RVA: 0x001E8E8C File Offset: 0x001E708C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015A48 RID: 88648
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOff_01(HandleRef pThis);

		/// <summary>
		/// Create a second output containing points and orientation vectors
		/// for drawing arrows or other glyphs on edges.  This output should be
		/// set as the first input to vtkGlyph3D to place glyphs on the edges.
		/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
		/// drawing arrows.
		/// Default value is off.
		/// </summary>
		// Token: 0x06015A49 RID: 88649 RVA: 0x001E8E97 File Offset: 0x001E7097
		public virtual void EdgeGlyphOutputOff()
		{
			vtkGraphToPolyData.vtkGraphToPolyData_EdgeGlyphOutputOff_01(base.GetCppThis());
		}

		// Token: 0x06015A4A RID: 88650
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToPolyData_EdgeGlyphOutputOn_02(HandleRef pThis);

		/// <summary>
		/// Create a second output containing points and orientation vectors
		/// for drawing arrows or other glyphs on edges.  This output should be
		/// set as the first input to vtkGlyph3D to place glyphs on the edges.
		/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
		/// drawing arrows.
		/// Default value is off.
		/// </summary>
		// Token: 0x06015A4B RID: 88651 RVA: 0x001E8EA6 File Offset: 0x001E70A6
		public virtual void EdgeGlyphOutputOn()
		{
			vtkGraphToPolyData.vtkGraphToPolyData_EdgeGlyphOutputOn_02(base.GetCppThis());
		}

		// Token: 0x06015A4C RID: 88652
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphToPolyData_GetEdgeGlyphOutput_03(HandleRef pThis);

		/// <summary>
		/// Create a second output containing points and orientation vectors
		/// for drawing arrows or other glyphs on edges.  This output should be
		/// set as the first input to vtkGlyph3D to place glyphs on the edges.
		/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
		/// drawing arrows.
		/// Default value is off.
		/// </summary>
		// Token: 0x06015A4D RID: 88653 RVA: 0x001E8EB8 File Offset: 0x001E70B8
		public virtual bool GetEdgeGlyphOutput()
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetEdgeGlyphOutput_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06015A4E RID: 88654
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphToPolyData_GetEdgeGlyphPosition_04(HandleRef pThis);

		/// <summary>
		/// The position of the glyph point along the edge.
		/// 0 puts a glyph point at the source of each edge.
		/// 1 puts a glyph point at the target of each edge.
		/// An intermediate value will place the glyph point between the source and target.
		/// The default value is 1.
		/// </summary>
		// Token: 0x06015A4F RID: 88655 RVA: 0x001E8EE0 File Offset: 0x001E70E0
		public virtual double GetEdgeGlyphPosition()
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetEdgeGlyphPosition_04(base.GetCppThis());
		}

		// Token: 0x06015A50 RID: 88656
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToPolyData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A51 RID: 88657 RVA: 0x001E8F00 File Offset: 0x001E7100
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06015A52 RID: 88658
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphToPolyData_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A53 RID: 88659 RVA: 0x001E8F20 File Offset: 0x001E7120
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06015A54 RID: 88660
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToPolyData_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A55 RID: 88661 RVA: 0x001E8F3C File Offset: 0x001E713C
		public override int IsA(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06015A56 RID: 88662
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphToPolyData_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A57 RID: 88663 RVA: 0x001E8F5C File Offset: 0x001E715C
		public new static int IsTypeOf(string type)
		{
			return vtkGraphToPolyData.vtkGraphToPolyData_IsTypeOf_08(type);
		}

		// Token: 0x06015A58 RID: 88664
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPolyData_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A59 RID: 88665 RVA: 0x001E8F78 File Offset: 0x001E7178
		public new vtkGraphToPolyData NewInstance()
		{
			vtkGraphToPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015A5A RID: 88666
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphToPolyData_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015A5B RID: 88667 RVA: 0x001E8FD4 File Offset: 0x001E71D4
		public new static vtkGraphToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkGraphToPolyData vtkGraphToPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphToPolyData.vtkGraphToPolyData_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphToPolyData = (vtkGraphToPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphToPolyData.Register(null);
				}
			}
			return vtkGraphToPolyData;
		}

		// Token: 0x06015A5C RID: 88668
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToPolyData_SetEdgeGlyphOutput_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Create a second output containing points and orientation vectors
		/// for drawing arrows or other glyphs on edges.  This output should be
		/// set as the first input to vtkGlyph3D to place glyphs on the edges.
		/// vtkGlyphSource2D's VTK_EDGEARROW_GLYPH provides a good glyph for
		/// drawing arrows.
		/// Default value is off.
		/// </summary>
		// Token: 0x06015A5D RID: 88669 RVA: 0x001E9053 File Offset: 0x001E7253
		public virtual void SetEdgeGlyphOutput(bool _arg)
		{
			vtkGraphToPolyData.vtkGraphToPolyData_SetEdgeGlyphOutput_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015A5E RID: 88670
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphToPolyData_SetEdgeGlyphPosition_13(HandleRef pThis, double _arg);

		/// <summary>
		/// The position of the glyph point along the edge.
		/// 0 puts a glyph point at the source of each edge.
		/// 1 puts a glyph point at the target of each edge.
		/// An intermediate value will place the glyph point between the source and target.
		/// The default value is 1.
		/// </summary>
		// Token: 0x06015A5F RID: 88671 RVA: 0x001E906B File Offset: 0x001E726B
		public virtual void SetEdgeGlyphPosition(double _arg)
		{
			vtkGraphToPolyData.vtkGraphToPolyData_SetEdgeGlyphPosition_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A2 RID: 6306
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphToPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018A3 RID: 6307
		public new static readonly string MRClassNameKey = "class vtkGraphToPolyData";
	}
}
