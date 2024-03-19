using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransformCoordinateSystems
	/// </summary>
	/// <remarks>
	///    transform points into different coordinate systems
	///
	/// This filter transforms points from one coordinate system to another. The user
	/// must specify the coordinate systems in which the input and output are
	/// specified. The user must also specify the VTK viewport (i.e., renderer) in
	/// which the transformation occurs.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCoordinate vtkTransformFilter vtkTransformPolyData vtkPolyDataMapper2D
	/// </seealso>
	// Token: 0x02000801 RID: 2049
	public class vtkTransformCoordinateSystems : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060150D3 RID: 86227 RVA: 0x001DCAA1 File Offset: 0x001DACA1
		static vtkTransformCoordinateSystems()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformCoordinateSystems.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformCoordinateSystems"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060150D4 RID: 86228 RVA: 0x001DCAC9 File Offset: 0x001DACC9
		public vtkTransformCoordinateSystems(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060150D5 RID: 86229
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCoordinateSystems_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class. By default no transformation is specified and
		/// the input and output is identical.
		/// </summary>
		// Token: 0x060150D6 RID: 86230 RVA: 0x001DCAD8 File Offset: 0x001DACD8
		public new static vtkTransformCoordinateSystems New()
		{
			vtkTransformCoordinateSystems result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class. By default no transformation is specified and
		/// the input and output is identical.
		/// </summary>
		// Token: 0x060150D7 RID: 86231 RVA: 0x001DCB2C File Offset: 0x001DAD2C
		public vtkTransformCoordinateSystems() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060150D8 RID: 86232 RVA: 0x001DCB70 File Offset: 0x001DAD70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060150D9 RID: 86233
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system in which the input is specified.
		/// The current options are World, Viewport, and Display. By default the
		/// input coordinate system is World.
		/// </summary>
		// Token: 0x060150DA RID: 86234 RVA: 0x001DCB7C File Offset: 0x001DAD7C
		public virtual int GetInputCoordinateSystem()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetInputCoordinateSystem_01(base.GetCppThis());
		}

		// Token: 0x060150DB RID: 86235
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTransformCoordinateSystems_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the instance of vtkCoordinate.
		/// </summary>
		// Token: 0x060150DC RID: 86236 RVA: 0x001DCB9C File Offset: 0x001DAD9C
		public override ulong GetMTime()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x060150DD RID: 86237
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150DE RID: 86238 RVA: 0x001DCBBC File Offset: 0x001DADBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060150DF RID: 86239
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150E0 RID: 86240 RVA: 0x001DCBDC File Offset: 0x001DADDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060150E1 RID: 86241
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCoordinateSystems_GetOutputCoordinateSystem_05(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system to which to transform the output.
		/// The current options are World, Viewport, and Display. By default the
		/// output coordinate system is Display.
		/// </summary>
		// Token: 0x060150E2 RID: 86242 RVA: 0x001DCBF8 File Offset: 0x001DADF8
		public virtual int GetOutputCoordinateSystem()
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetOutputCoordinateSystem_05(base.GetCppThis());
		}

		// Token: 0x060150E3 RID: 86243
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCoordinateSystems_GetViewport_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// In order for a successful coordinate transformation to occur, an
		/// instance of vtkViewport (e.g., a VTK renderer) must be specified.
		/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
		/// object, to avoid reference cycle loop between rendering classes and filter
		/// classes.
		/// </summary>
		// Token: 0x060150E4 RID: 86244 RVA: 0x001DCC18 File Offset: 0x001DAE18
		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_GetViewport_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		// Token: 0x060150E5 RID: 86245
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCoordinateSystems_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150E6 RID: 86246 RVA: 0x001DCC88 File Offset: 0x001DAE88
		public override int IsA(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060150E7 RID: 86247
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransformCoordinateSystems_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150E8 RID: 86248 RVA: 0x001DCCA8 File Offset: 0x001DAEA8
		public new static int IsTypeOf(string type)
		{
			return vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_IsTypeOf_08(type);
		}

		// Token: 0x060150E9 RID: 86249
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCoordinateSystems_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150EA RID: 86250 RVA: 0x001DCCC4 File Offset: 0x001DAEC4
		public new vtkTransformCoordinateSystems NewInstance()
		{
			vtkTransformCoordinateSystems result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060150EB RID: 86251
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransformCoordinateSystems_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060150EC RID: 86252 RVA: 0x001DCD20 File Offset: 0x001DAF20
		public new static vtkTransformCoordinateSystems SafeDownCast(vtkObjectBase o)
		{
			vtkTransformCoordinateSystems vtkTransformCoordinateSystems = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformCoordinateSystems = (vtkTransformCoordinateSystems)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformCoordinateSystems.Register(null);
				}
			}
			return vtkTransformCoordinateSystems;
		}

		// Token: 0x060150ED RID: 86253
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystem_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the coordinate system in which the input is specified.
		/// The current options are World, Viewport, and Display. By default the
		/// input coordinate system is World.
		/// </summary>
		// Token: 0x060150EE RID: 86254 RVA: 0x001DCD9F File Offset: 0x001DAF9F
		public virtual void SetInputCoordinateSystem(int _arg)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystem_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060150EF RID: 86255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_13(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system in which the input is specified.
		/// The current options are World, Viewport, and Display. By default the
		/// input coordinate system is World.
		/// </summary>
		// Token: 0x060150F0 RID: 86256 RVA: 0x001DCDAF File Offset: 0x001DAFAF
		public void SetInputCoordinateSystemToDisplay()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToDisplay_13(base.GetCppThis());
		}

		// Token: 0x060150F1 RID: 86257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_14(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system in which the input is specified.
		/// The current options are World, Viewport, and Display. By default the
		/// input coordinate system is World.
		/// </summary>
		// Token: 0x060150F2 RID: 86258 RVA: 0x001DCDBE File Offset: 0x001DAFBE
		public void SetInputCoordinateSystemToViewport()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToViewport_14(base.GetCppThis());
		}

		// Token: 0x060150F3 RID: 86259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_15(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system in which the input is specified.
		/// The current options are World, Viewport, and Display. By default the
		/// input coordinate system is World.
		/// </summary>
		// Token: 0x060150F4 RID: 86260 RVA: 0x001DCDCD File Offset: 0x001DAFCD
		public void SetInputCoordinateSystemToWorld()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetInputCoordinateSystemToWorld_15(base.GetCppThis());
		}

		// Token: 0x060150F5 RID: 86261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystem_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the coordinate system to which to transform the output.
		/// The current options are World, Viewport, and Display. By default the
		/// output coordinate system is Display.
		/// </summary>
		// Token: 0x060150F6 RID: 86262 RVA: 0x001DCDDC File Offset: 0x001DAFDC
		public virtual void SetOutputCoordinateSystem(int _arg)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystem_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060150F7 RID: 86263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_17(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system to which to transform the output.
		/// The current options are World, Viewport, and Display. By default the
		/// output coordinate system is Display.
		/// </summary>
		// Token: 0x060150F8 RID: 86264 RVA: 0x001DCDEC File Offset: 0x001DAFEC
		public void SetOutputCoordinateSystemToDisplay()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToDisplay_17(base.GetCppThis());
		}

		// Token: 0x060150F9 RID: 86265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_18(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system to which to transform the output.
		/// The current options are World, Viewport, and Display. By default the
		/// output coordinate system is Display.
		/// </summary>
		// Token: 0x060150FA RID: 86266 RVA: 0x001DCDFB File Offset: 0x001DAFFB
		public void SetOutputCoordinateSystemToViewport()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToViewport_18(base.GetCppThis());
		}

		// Token: 0x060150FB RID: 86267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_19(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system to which to transform the output.
		/// The current options are World, Viewport, and Display. By default the
		/// output coordinate system is Display.
		/// </summary>
		// Token: 0x060150FC RID: 86268 RVA: 0x001DCE0A File Offset: 0x001DB00A
		public void SetOutputCoordinateSystemToWorld()
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetOutputCoordinateSystemToWorld_19(base.GetCppThis());
		}

		// Token: 0x060150FD RID: 86269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTransformCoordinateSystems_SetViewport_20(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// In order for a successful coordinate transformation to occur, an
		/// instance of vtkViewport (e.g., a VTK renderer) must be specified.
		/// NOTE: this is a raw pointer, not a weak pointer nor a reference counted
		/// object, to avoid reference cycle loop between rendering classes and filter
		/// classes.
		/// </summary>
		// Token: 0x060150FE RID: 86270 RVA: 0x001DCE1C File Offset: 0x001DB01C
		public void SetViewport(vtkViewport viewport)
		{
			vtkTransformCoordinateSystems.vtkTransformCoordinateSystems_SetViewport_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001846 RID: 6214
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformCoordinateSystems";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001847 RID: 6215
		public new static readonly string MRClassNameKey = "class vtkTransformCoordinateSystems";
	}
}
