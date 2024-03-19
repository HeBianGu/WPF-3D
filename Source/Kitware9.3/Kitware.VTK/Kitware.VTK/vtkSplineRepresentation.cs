using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplineRepresentation
	/// </summary>
	/// <remarks>
	///    representation for a spline.
	///
	/// vtkSplineRepresentation is a vtkWidgetRepresentation for a spline.
	/// This 3D widget defines a spline that can be interactively placed in a
	/// scene. The spline has handles, the number of which can be changed, plus it
	/// can be picked on the spline itself to translate or rotate it in the scene.
	/// This is based on vtkSplineWidget.
	/// </remarks>
	/// <seealso>
	///
	/// vtkSplineWidget, vtkSplineWidget2
	/// </seealso>
	// Token: 0x0200037D RID: 893
	public class vtkSplineRepresentation : vtkAbstractSplineRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A297 RID: 41623 RVA: 0x000E67E1 File Offset: 0x000E49E1
		static vtkSplineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A298 RID: 41624 RVA: 0x000E6809 File Offset: 0x000E4A09
		public vtkSplineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A299 RID: 41625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A29A RID: 41626 RVA: 0x000E6818 File Offset: 0x000E4A18
		public new static vtkSplineRepresentation New()
		{
			vtkSplineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A29B RID: 41627 RVA: 0x000E686C File Offset: 0x000E4A6C
		public vtkSplineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplineRepresentation.vtkSplineRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A29C RID: 41628 RVA: 0x000E68B0 File Offset: 0x000E4AB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A29D RID: 41629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method that satisfy vtkWidgetRepresentation API.
		/// Updates the spline in relation with the handles positions
		/// and updates vtkWidgetRepresentation::InitialLength
		/// (useful for the sizing methods).
		/// </summary>
		// Token: 0x0600A29E RID: 41630 RVA: 0x000E68BB File Offset: 0x000E4ABB
		public override void BuildRepresentation()
		{
			vtkSplineRepresentation.vtkSplineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A29F RID: 41631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2A0 RID: 41632 RVA: 0x000E68CC File Offset: 0x000E4ACC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A2A1 RID: 41633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplineRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2A2 RID: 41634 RVA: 0x000E68EC File Offset: 0x000E4AEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A2A3 RID: 41635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineRepresentation_InitializeHandles_04(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the handles from a vtkPoints
		/// instance.  If the first and last points are the same, the spline sets
		/// Closed to the on InteractionState and disregards the last point, otherwise Closed
		/// remains unchanged.
		/// </summary>
		// Token: 0x0600A2A4 RID: 41636 RVA: 0x000E6908 File Offset: 0x000E4B08
		public override void InitializeHandles(vtkPoints points)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_InitializeHandles_04(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x0600A2A5 RID: 41637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineRepresentation_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2A6 RID: 41638 RVA: 0x000E6938 File Offset: 0x000E4B38
		public override int IsA(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A2A7 RID: 41639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplineRepresentation_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2A8 RID: 41640 RVA: 0x000E6958 File Offset: 0x000E4B58
		public new static int IsTypeOf(string type)
		{
			return vtkSplineRepresentation.vtkSplineRepresentation_IsTypeOf_06(type);
		}

		// Token: 0x0600A2A9 RID: 41641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2AA RID: 41642 RVA: 0x000E6974 File Offset: 0x000E4B74
		public new vtkSplineRepresentation NewInstance()
		{
			vtkSplineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A2AB RID: 41643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplineRepresentation_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A2AC RID: 41644 RVA: 0x000E69D0 File Offset: 0x000E4BD0
		public new static vtkSplineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkSplineRepresentation vtkSplineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplineRepresentation.vtkSplineRepresentation_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplineRepresentation = (vtkSplineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplineRepresentation.Register(null);
				}
			}
			return vtkSplineRepresentation;
		}

		// Token: 0x0600A2AD RID: 41645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineRepresentation_SetNumberOfHandles_10(HandleRef pThis, int npts);

		/// <summary>
		/// Set the number of handles for this widget,
		///  while keeping a similar spline.
		/// </summary>
		// Token: 0x0600A2AE RID: 41646 RVA: 0x000E6A4F File Offset: 0x000E4C4F
		public override void SetNumberOfHandles(int npts)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetNumberOfHandles_10(base.GetCppThis(), npts);
		}

		// Token: 0x0600A2AF RID: 41647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplineRepresentation_SetParametricSpline_11(HandleRef pThis, HandleRef spline);

		/// <summary>
		/// Set the parametric spline object.
		/// </summary>
		// Token: 0x0600A2B0 RID: 41648 RVA: 0x000E6A60 File Offset: 0x000E4C60
		public override void SetParametricSpline(vtkParametricSpline spline)
		{
			vtkSplineRepresentation.vtkSplineRepresentation_SetParametricSpline_11(base.GetCppThis(), (spline == null) ? default(HandleRef) : spline.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D08 RID: 3336
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D09 RID: 3337
		public new static readonly string MRClassNameKey = "class vtkSplineRepresentation";
	}
}
