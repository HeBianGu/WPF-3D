using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractSplineRepresentation
	/// </summary>
	/// <remarks>
	///    abstract representation for a spline.
	///
	/// vtkAbstractSplineRepresentation is a vtkWidgetRepresentation for an abstract spline.
	/// This 3D widget defines a spline that can be accessed, set and configured.
	/// Deriving classes are then able to combine their own handles using this class.
	/// </remarks>
	// Token: 0x020002B2 RID: 690
	public abstract class vtkAbstractSplineRepresentation : vtkCurveRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007D06 RID: 32006 RVA: 0x000B385B File Offset: 0x000B1A5B
		static vtkAbstractSplineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractSplineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractSplineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007D07 RID: 32007 RVA: 0x000B3883 File Offset: 0x000B1A83
		public vtkAbstractSplineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007D08 RID: 32008 RVA: 0x000B3891 File Offset: 0x000B1A91
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007D09 RID: 32009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractSplineRepresentation_GetHandlePositions_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the position of the spline handles.
		/// </summary>
		// Token: 0x06007D0A RID: 32010 RVA: 0x000B389C File Offset: 0x000B1A9C
		public override vtkDoubleArray GetHandlePositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetHandlePositions_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x06007D0B RID: 32011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D0C RID: 32012 RVA: 0x000B390C File Offset: 0x000B1B0C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007D0D RID: 32013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D0E RID: 32014 RVA: 0x000B392C File Offset: 0x000B1B2C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06007D0F RID: 32015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractSplineRepresentation_GetParametricSpline_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the parametric spline object.
		/// Can be redefined in the child classes for further updates
		/// when a spline is set.
		/// The default value is nullptr.
		/// </summary>
		// Token: 0x06007D10 RID: 32016 RVA: 0x000B3948 File Offset: 0x000B1B48
		public virtual vtkParametricSpline GetParametricSpline()
		{
			vtkParametricSpline vtkParametricSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetParametricSpline_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParametricSpline = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParametricSpline.Register(null);
				}
			}
			return vtkParametricSpline;
		}

		// Token: 0x06007D11 RID: 32017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractSplineRepresentation_GetPolyData_05(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the spline.  The
		/// polydata consists of points and line segments numbering Resolution + 1
		/// and Resolution, respectively. Points are guaranteed to be up-to-date when
		/// either the InteractionEvent or EndInteraction events are invoked. The
		/// user provides the vtkPolyData and the points and polyline are added to it.
		/// </summary>
		// Token: 0x06007D12 RID: 32018 RVA: 0x000B39B8 File Offset: 0x000B1BB8
		public override void GetPolyData(vtkPolyData pd)
		{
			vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetPolyData_05(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06007D13 RID: 32019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractSplineRepresentation_GetResolution_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of line segments representing the spline for
		/// this widget.
		/// The default value is 499.
		/// </summary>
		// Token: 0x06007D14 RID: 32020 RVA: 0x000B39E8 File Offset: 0x000B1BE8
		public virtual int GetResolution()
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetResolution_06(base.GetCppThis());
		}

		// Token: 0x06007D15 RID: 32021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractSplineRepresentation_GetSummedLength_07(HandleRef pThis);

		/// <summary>
		/// Get the approximate vs. the true arc length of the spline. Calculated as
		/// the summed lengths of the individual straight line segments. Use
		/// SetResolution to control the accuracy.
		/// </summary>
		// Token: 0x06007D16 RID: 32022 RVA: 0x000B3A08 File Offset: 0x000B1C08
		public override double GetSummedLength()
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_GetSummedLength_07(base.GetCppThis());
		}

		// Token: 0x06007D17 RID: 32023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractSplineRepresentation_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D18 RID: 32024 RVA: 0x000B3A28 File Offset: 0x000B1C28
		public override int IsA(string type)
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06007D19 RID: 32025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractSplineRepresentation_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D1A RID: 32026 RVA: 0x000B3A48 File Offset: 0x000B1C48
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_IsTypeOf_09(type);
		}

		// Token: 0x06007D1B RID: 32027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractSplineRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D1C RID: 32028 RVA: 0x000B3A64 File Offset: 0x000B1C64
		public new vtkAbstractSplineRepresentation NewInstance()
		{
			vtkAbstractSplineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractSplineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007D1D RID: 32029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractSplineRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007D1E RID: 32030 RVA: 0x000B3AC0 File Offset: 0x000B1CC0
		public new static vtkAbstractSplineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractSplineRepresentation vtkAbstractSplineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractSplineRepresentation = (vtkAbstractSplineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractSplineRepresentation.Register(null);
				}
			}
			return vtkAbstractSplineRepresentation;
		}

		// Token: 0x06007D1F RID: 32031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractSplineRepresentation_SetParametricSpline_12(HandleRef pThis, HandleRef spline);

		/// <summary>
		/// Set the parametric spline object.
		/// Can be redefined in the child classes for further updates
		/// when a spline is set.
		/// The default value is nullptr.
		/// </summary>
		// Token: 0x06007D20 RID: 32032 RVA: 0x000B3B40 File Offset: 0x000B1D40
		public virtual void SetParametricSpline(vtkParametricSpline spline)
		{
			vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_SetParametricSpline_12(base.GetCppThis(), (spline == null) ? default(HandleRef) : spline.GetCppThis());
		}

		// Token: 0x06007D21 RID: 32033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractSplineRepresentation_SetResolution_13(HandleRef pThis, int resolution);

		/// <summary>
		/// Set/Get the number of line segments representing the spline for
		/// this widget.
		/// The default value is 499.
		/// </summary>
		// Token: 0x06007D22 RID: 32034 RVA: 0x000B3B6F File Offset: 0x000B1D6F
		public void SetResolution(int resolution)
		{
			vtkAbstractSplineRepresentation.vtkAbstractSplineRepresentation_SetResolution_13(base.GetCppThis(), resolution);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A82 RID: 2690
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractSplineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A83 RID: 2691
		public new static readonly string MRClassNameKey = "class vtkAbstractSplineRepresentation";
	}
}
