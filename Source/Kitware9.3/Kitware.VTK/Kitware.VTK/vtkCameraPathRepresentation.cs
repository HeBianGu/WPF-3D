using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraPathRepresentation
	/// </summary>
	/// <remarks>
	///    representation for a camera path.
	///
	/// vtkCameraPathRepresentation is a vtkWidgetRepresentation for a camera path.
	/// This 3D widget defines a camera path that can be interactively manipulated in a
	/// scene. The camera path has camera handles, that can be added and deleted, plus they
	/// can be picked on the path itself to be translated in the scene.
	/// This representation is used with vtkCameraPathWidget.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCameraPathWidget
	/// </seealso>
	// Token: 0x020002E8 RID: 744
	public class vtkCameraPathRepresentation : vtkAbstractSplineRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060085D5 RID: 34261 RVA: 0x000BEF27 File Offset: 0x000BD127
		static vtkCameraPathRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraPathRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraPathRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060085D6 RID: 34262 RVA: 0x000BEF4F File Offset: 0x000BD14F
		public vtkCameraPathRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060085D7 RID: 34263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085D8 RID: 34264 RVA: 0x000BEF60 File Offset: 0x000BD160
		public new static vtkCameraPathRepresentation New()
		{
			vtkCameraPathRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathRepresentation.vtkCameraPathRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085D9 RID: 34265 RVA: 0x000BEFB4 File Offset: 0x000BD1B4
		public vtkCameraPathRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraPathRepresentation.vtkCameraPathRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060085DA RID: 34266 RVA: 0x000BEFF8 File Offset: 0x000BD1F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060085DB RID: 34267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_AddCameraAt_01(HandleRef pThis, HandleRef camera, int index);

		/// <summary>
		/// Add a camera to the path.
		/// </summary>
		// Token: 0x060085DC RID: 34268 RVA: 0x000BF004 File Offset: 0x000BD204
		public void AddCameraAt(vtkCamera camera, int index)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_AddCameraAt_01(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis(), index);
		}

		// Token: 0x060085DD RID: 34269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_BuildRepresentation_02(HandleRef pThis);

		/// <summary>
		/// Method that satisfy vtkWidgetRepresentation API.
		/// Updates the spline in relation with the handles positions
		/// and updates vtkWidgetRepresentation::InitialLength
		/// (useful for the sizing methods).
		/// </summary>
		// Token: 0x060085DE RID: 34270 RVA: 0x000BF034 File Offset: 0x000BD234
		public override void BuildRepresentation()
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_BuildRepresentation_02(base.GetCppThis());
		}

		// Token: 0x060085DF RID: 34271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_DeleteCameraAt_03(HandleRef pThis, int index);

		/// <summary>
		/// Remove a camera from the path.
		/// </summary>
		// Token: 0x060085E0 RID: 34272 RVA: 0x000BF043 File Offset: 0x000BD243
		public void DeleteCameraAt(int index)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_DeleteCameraAt_03(base.GetCppThis(), index);
		}

		// Token: 0x060085E1 RID: 34273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPathRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085E2 RID: 34274 RVA: 0x000BF054 File Offset: 0x000BD254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraPathRepresentation.vtkCameraPathRepresentation_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060085E3 RID: 34275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraPathRepresentation_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085E4 RID: 34276 RVA: 0x000BF074 File Offset: 0x000BD274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraPathRepresentation.vtkCameraPathRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060085E5 RID: 34277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_InitializeHandles_06(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the Camera handles from a vtkPoints
		/// instance (corresponding to the camera positions).
		/// If the first and last points are the same, the spline sets
		/// Closed to the on InteractionState and disregards the last point, otherwise Closed
		/// remains unchanged.
		/// </summary>
		// Token: 0x060085E6 RID: 34278 RVA: 0x000BF090 File Offset: 0x000BD290
		public override void InitializeHandles(vtkPoints points)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_InitializeHandles_06(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x060085E7 RID: 34279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPathRepresentation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085E8 RID: 34280 RVA: 0x000BF0C0 File Offset: 0x000BD2C0
		public override int IsA(string type)
		{
			return vtkCameraPathRepresentation.vtkCameraPathRepresentation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060085E9 RID: 34281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraPathRepresentation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085EA RID: 34282 RVA: 0x000BF0E0 File Offset: 0x000BD2E0
		public new static int IsTypeOf(string type)
		{
			return vtkCameraPathRepresentation.vtkCameraPathRepresentation_IsTypeOf_08(type);
		}

		// Token: 0x060085EB RID: 34283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085EC RID: 34284 RVA: 0x000BF0FC File Offset: 0x000BD2FC
		public new vtkCameraPathRepresentation NewInstance()
		{
			vtkCameraPathRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathRepresentation.vtkCameraPathRepresentation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060085ED RID: 34285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraPathRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085EE RID: 34286 RVA: 0x000BF158 File Offset: 0x000BD358
		public new static vtkCameraPathRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCameraPathRepresentation vtkCameraPathRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraPathRepresentation.vtkCameraPathRepresentation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraPathRepresentation = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraPathRepresentation.Register(null);
				}
			}
			return vtkCameraPathRepresentation;
		}

		// Token: 0x060085EF RID: 34287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_SetDirectional_12(HandleRef pThis, byte val);

		/// <summary>
		/// Sets the representation to be a curve interpolating multiple cameras pointing to their focal
		/// point. If set to false, the cameras are only represented as spheres.
		/// </summary>
		// Token: 0x060085F0 RID: 34288 RVA: 0x000BF1D7 File Offset: 0x000BD3D7
		public override void SetDirectional(bool val)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_SetDirectional_12(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x060085F1 RID: 34289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_SetNumberOfHandles_13(HandleRef pThis, int npts);

		/// <summary>
		/// Adjust the number of camera handles while keeping
		///             he same path.
		/// </summary>
		// Token: 0x060085F2 RID: 34290 RVA: 0x000BF1EF File Offset: 0x000BD3EF
		public override void SetNumberOfHandles(int npts)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_SetNumberOfHandles_13(base.GetCppThis(), npts);
		}

		// Token: 0x060085F3 RID: 34291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraPathRepresentation_SetParametricSpline_14(HandleRef pThis, HandleRef spline);

		/// <summary>
		/// Set the parametric spline object.
		/// </summary>
		// Token: 0x060085F4 RID: 34292 RVA: 0x000BF200 File Offset: 0x000BD400
		public override void SetParametricSpline(vtkParametricSpline spline)
		{
			vtkCameraPathRepresentation.vtkCameraPathRepresentation_SetParametricSpline_14(base.GetCppThis(), (spline == null) ? default(HandleRef) : spline.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B51 RID: 2897
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraPathRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B52 RID: 2898
		public new static readonly string MRClassNameKey = "class vtkCameraPathRepresentation";
	}
}
