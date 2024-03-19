using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlotGrid
	/// </summary>
	/// <remarks>
	///    takes care of drawing the plot grid
	///
	///
	/// The vtkPlotGrid is drawn in screen coordinates. It is usually one of the
	/// first elements of a chart to be drawn, and will generally be obscured
	/// by all other elements of the chart. It builds up its own plot locations
	/// from the parameters of the x and y axis of the plot.
	/// </remarks>
	// Token: 0x02000662 RID: 1634
	public class vtkPlotGrid : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011A47 RID: 72263 RVA: 0x0018A5AE File Offset: 0x001887AE
		static vtkPlotGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011A48 RID: 72264 RVA: 0x0018A5D6 File Offset: 0x001887D6
		public vtkPlotGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011A49 RID: 72265
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011A4A RID: 72266 RVA: 0x0018A5E4 File Offset: 0x001887E4
		public new static vtkPlotGrid New()
		{
			vtkPlotGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a 2D Chart object.
		/// </summary>
		// Token: 0x06011A4B RID: 72267 RVA: 0x0018A638 File Offset: 0x00188838
		public vtkPlotGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlotGrid.vtkPlotGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011A4C RID: 72268 RVA: 0x0018A67C File Offset: 0x0018887C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011A4D RID: 72269
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotGrid_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A4E RID: 72270 RVA: 0x0018A688 File Offset: 0x00188888
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011A4F RID: 72271
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlotGrid_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A50 RID: 72272 RVA: 0x0018A6A8 File Offset: 0x001888A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011A51 RID: 72273
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotGrid_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A52 RID: 72274 RVA: 0x0018A6C4 File Offset: 0x001888C4
		public override int IsA(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011A53 RID: 72275
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlotGrid_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A54 RID: 72276 RVA: 0x0018A6E4 File Offset: 0x001888E4
		public new static int IsTypeOf(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_IsTypeOf_04(type);
		}

		// Token: 0x06011A55 RID: 72277
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotGrid_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A56 RID: 72278 RVA: 0x0018A700 File Offset: 0x00188900
		public new vtkPlotGrid NewInstance()
		{
			vtkPlotGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011A57 RID: 72279
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPlotGrid_Paint_07(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the axis, called whenever the axis needs to be drawn
		/// </summary>
		// Token: 0x06011A58 RID: 72280 RVA: 0x0018A75C File Offset: 0x0018895C
		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotGrid.vtkPlotGrid_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06011A59 RID: 72281
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlotGrid_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011A5A RID: 72282 RVA: 0x0018A798 File Offset: 0x00188998
		public new static vtkPlotGrid SafeDownCast(vtkObjectBase o)
		{
			vtkPlotGrid vtkPlotGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotGrid = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotGrid.Register(null);
				}
			}
			return vtkPlotGrid;
		}

		// Token: 0x06011A5B RID: 72283
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotGrid_SetXAxis_09(HandleRef pThis, HandleRef axis);

		/// <summary>
		/// Set the X axis of the grid.
		/// </summary>
		// Token: 0x06011A5C RID: 72284 RVA: 0x0018A818 File Offset: 0x00188A18
		public virtual void SetXAxis(vtkAxis axis)
		{
			vtkPlotGrid.vtkPlotGrid_SetXAxis_09(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		// Token: 0x06011A5D RID: 72285
		[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlotGrid_SetYAxis_10(HandleRef pThis, HandleRef axis);

		/// <summary>
		/// Set the X axis of the grid.
		/// </summary>
		// Token: 0x06011A5E RID: 72286 RVA: 0x0018A848 File Offset: 0x00188A48
		public virtual void SetYAxis(vtkAxis axis)
		{
			vtkPlotGrid.vtkPlotGrid_SetYAxis_10(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145D RID: 5213
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400145E RID: 5214
		public new static readonly string MRClassNameKey = "class vtkPlotGrid";
	}
}
