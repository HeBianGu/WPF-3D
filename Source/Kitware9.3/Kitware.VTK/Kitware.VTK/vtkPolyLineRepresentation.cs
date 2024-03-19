using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyLineRepresentation
	/// </summary>
	/// <remarks>
	///    vtkWidgetRepresentation for a poly line.
	///
	/// vtkPolyLineRepresentation is a vtkCurveRepresentation for a poly
	/// line. This 3D widget defines a poly line that can be interactively
	/// placed in a scene. The poly line has handles, the number of which
	/// can be changed, plus the widget can be picked on the poly line
	/// itself to translate or rotate it in the scene.
	/// Based on vtkCurveRepresentation
	/// </remarks>
	/// <seealso>
	///
	/// vtkSplineRepresentation
	/// </seealso>
	// Token: 0x0200035A RID: 858
	public class vtkPolyLineRepresentation : vtkCurveRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009C34 RID: 39988 RVA: 0x000DD489 File Offset: 0x000DB689
		static vtkPolyLineRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyLineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyLineRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009C35 RID: 39989 RVA: 0x000DD4B1 File Offset: 0x000DB6B1
		public vtkPolyLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009C36 RID: 39990
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C37 RID: 39991 RVA: 0x000DD4C0 File Offset: 0x000DB6C0
		public new static vtkPolyLineRepresentation New()
		{
			vtkPolyLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineRepresentation.vtkPolyLineRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C38 RID: 39992 RVA: 0x000DD514 File Offset: 0x000DB714
		public vtkPolyLineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyLineRepresentation.vtkPolyLineRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009C39 RID: 39993 RVA: 0x000DD558 File Offset: 0x000DB758
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009C3A RID: 39994
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Build the representation for the poly line.
		/// </summary>
		// Token: 0x06009C3B RID: 39995 RVA: 0x000DD563 File Offset: 0x000DB763
		public override void BuildRepresentation()
		{
			vtkPolyLineRepresentation.vtkPolyLineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009C3C RID: 39996
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineRepresentation_GetHandlePositions_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the positions of the handles.
		/// </summary>
		// Token: 0x06009C3D RID: 39997 RVA: 0x000DD574 File Offset: 0x000DB774
		public override vtkDoubleArray GetHandlePositions()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineRepresentation.vtkPolyLineRepresentation_GetHandlePositions_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009C3E RID: 39998
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineRepresentation_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C3F RID: 39999 RVA: 0x000DD5E4 File Offset: 0x000DB7E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyLineRepresentation.vtkPolyLineRepresentation_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06009C40 RID: 40000
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyLineRepresentation_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C41 RID: 40001 RVA: 0x000DD604 File Offset: 0x000DB804
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyLineRepresentation.vtkPolyLineRepresentation_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06009C42 RID: 40002
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineRepresentation_GetPolyData_05(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the poly line.
		/// polydata consists of points and line segments between consecutive
		/// points. Points are guaranteed to be up-to-date when either the
		/// InteractionEvent or EndInteraction events are invoked. The user
		/// provides the vtkPolyData and the points and polyline are added to
		/// it.
		/// </summary>
		// Token: 0x06009C43 RID: 40003 RVA: 0x000DD620 File Offset: 0x000DB820
		public override void GetPolyData(vtkPolyData pd)
		{
			vtkPolyLineRepresentation.vtkPolyLineRepresentation_GetPolyData_05(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06009C44 RID: 40004
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyLineRepresentation_GetSummedLength_06(HandleRef pThis);

		/// <summary>
		/// Get the true length of the poly line. Calculated as the summed
		/// lengths of the individual straight line segments.
		/// </summary>
		// Token: 0x06009C45 RID: 40005 RVA: 0x000DD650 File Offset: 0x000DB850
		public override double GetSummedLength()
		{
			return vtkPolyLineRepresentation.vtkPolyLineRepresentation_GetSummedLength_06(base.GetCppThis());
		}

		// Token: 0x06009C46 RID: 40006
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineRepresentation_InitializeHandles_07(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the handles from a
		/// vtkPoints instance.  If the first and last points are the same,
		/// the poly line sets Closed to on and disregards the last point,
		/// otherwise Closed remains unchanged.
		/// </summary>
		// Token: 0x06009C47 RID: 40007 RVA: 0x000DD670 File Offset: 0x000DB870
		public override void InitializeHandles(vtkPoints points)
		{
			vtkPolyLineRepresentation.vtkPolyLineRepresentation_InitializeHandles_07(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06009C48 RID: 40008
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineRepresentation_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C49 RID: 40009 RVA: 0x000DD6A0 File Offset: 0x000DB8A0
		public override int IsA(string type)
		{
			return vtkPolyLineRepresentation.vtkPolyLineRepresentation_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06009C4A RID: 40010
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyLineRepresentation_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C4B RID: 40011 RVA: 0x000DD6C0 File Offset: 0x000DB8C0
		public new static int IsTypeOf(string type)
		{
			return vtkPolyLineRepresentation.vtkPolyLineRepresentation_IsTypeOf_09(type);
		}

		// Token: 0x06009C4C RID: 40012
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineRepresentation_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C4D RID: 40013 RVA: 0x000DD6DC File Offset: 0x000DB8DC
		public new vtkPolyLineRepresentation NewInstance()
		{
			vtkPolyLineRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineRepresentation.vtkPolyLineRepresentation_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009C4E RID: 40014
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyLineRepresentation_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009C4F RID: 40015 RVA: 0x000DD738 File Offset: 0x000DB938
		public new static vtkPolyLineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkPolyLineRepresentation vtkPolyLineRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyLineRepresentation.vtkPolyLineRepresentation_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyLineRepresentation = (vtkPolyLineRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyLineRepresentation.Register(null);
				}
			}
			return vtkPolyLineRepresentation;
		}

		// Token: 0x06009C50 RID: 40016
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyLineRepresentation_SetNumberOfHandles_13(HandleRef pThis, int npts);

		/// <summary>
		/// Set the number of handles for this widget.
		/// </summary>
		// Token: 0x06009C51 RID: 40017 RVA: 0x000DD7B7 File Offset: 0x000DB9B7
		public override void SetNumberOfHandles(int npts)
		{
			vtkPolyLineRepresentation.vtkPolyLineRepresentation_SetNumberOfHandles_13(base.GetCppThis(), npts);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA7 RID: 3239
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyLineRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CA8 RID: 3240
		public new static readonly string MRClassNameKey = "class vtkPolyLineRepresentation";
	}
}
