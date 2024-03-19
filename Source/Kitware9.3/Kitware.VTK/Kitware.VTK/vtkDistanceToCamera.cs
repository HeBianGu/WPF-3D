using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistanceToCamera
	/// </summary>
	/// <remarks>
	///    calculates distance from points to the camera.
	///
	///
	/// This filter adds a double array containing the distance from each point
	/// to the camera. If Scaling is on, it will use the values in the input
	/// array to process in order to scale the size of the points. ScreenSize
	/// sets the size in screen pixels that you would want a rendered rectangle
	/// at that point to be, if it was scaled by the output array.
	/// </remarks>
	// Token: 0x020007DB RID: 2011
	public class vtkDistanceToCamera : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014A64 RID: 84580 RVA: 0x001D3C0B File Offset: 0x001D1E0B
		static vtkDistanceToCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceToCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceToCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014A65 RID: 84581 RVA: 0x001D3C33 File Offset: 0x001D1E33
		public vtkDistanceToCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014A66 RID: 84582
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceToCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A67 RID: 84583 RVA: 0x001D3C44 File Offset: 0x001D1E44
		public new static vtkDistanceToCamera New()
		{
			vtkDistanceToCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A68 RID: 84584 RVA: 0x001D3C98 File Offset: 0x001D1E98
		public vtkDistanceToCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistanceToCamera.vtkDistanceToCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014A69 RID: 84585 RVA: 0x001D3CDC File Offset: 0x001D1EDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014A6A RID: 84586
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceToCamera_GetDistanceArrayName_01(HandleRef pThis);

		/// <summary>
		/// The name of the distance array. If not set, the array is
		/// named 'DistanceToCamera'.
		/// </summary>
		// Token: 0x06014A6B RID: 84587 RVA: 0x001D3CE8 File Offset: 0x001D1EE8
		public virtual string GetDistanceArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDistanceToCamera.vtkDistanceToCamera_GetDistanceArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014A6C RID: 84588
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDistanceToCamera_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// The modified time of this filter.
		/// </summary>
		// Token: 0x06014A6D RID: 84589 RVA: 0x001D3D24 File Offset: 0x001D1F24
		public override ulong GetMTime()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06014A6E RID: 84590
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceToCamera_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A6F RID: 84591 RVA: 0x001D3D44 File Offset: 0x001D1F44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014A70 RID: 84592
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceToCamera_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A71 RID: 84593 RVA: 0x001D3D64 File Offset: 0x001D1F64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014A72 RID: 84594
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceToCamera_GetRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The renderer which will ultimately render these points.
		/// </summary>
		// Token: 0x06014A73 RID: 84595 RVA: 0x001D3D80 File Offset: 0x001D1F80
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_GetRenderer_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06014A74 RID: 84596
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDistanceToCamera_GetScaling_06(HandleRef pThis);

		/// <summary>
		/// Whether to scale the distance by the input array to process.
		/// </summary>
		// Token: 0x06014A75 RID: 84597 RVA: 0x001D3DF0 File Offset: 0x001D1FF0
		public virtual bool GetScaling()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetScaling_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06014A76 RID: 84598
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceToCamera_GetScreenSize_07(HandleRef pThis);

		/// <summary>
		/// The desired screen size obtained by scaling glyphs by the distance
		/// array. It assumes the glyph at each point will be unit size.
		/// </summary>
		// Token: 0x06014A77 RID: 84599 RVA: 0x001D3E18 File Offset: 0x001D2018
		public virtual double GetScreenSize()
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_GetScreenSize_07(base.GetCppThis());
		}

		// Token: 0x06014A78 RID: 84600
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceToCamera_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A79 RID: 84601 RVA: 0x001D3E38 File Offset: 0x001D2038
		public override int IsA(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06014A7A RID: 84602
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceToCamera_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A7B RID: 84603 RVA: 0x001D3E58 File Offset: 0x001D2058
		public new static int IsTypeOf(string type)
		{
			return vtkDistanceToCamera.vtkDistanceToCamera_IsTypeOf_09(type);
		}

		// Token: 0x06014A7C RID: 84604
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceToCamera_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A7D RID: 84605 RVA: 0x001D3E74 File Offset: 0x001D2074
		public new vtkDistanceToCamera NewInstance()
		{
			vtkDistanceToCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014A7E RID: 84606
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceToCamera_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014A7F RID: 84607 RVA: 0x001D3ED0 File Offset: 0x001D20D0
		public new static vtkDistanceToCamera SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceToCamera vtkDistanceToCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceToCamera.vtkDistanceToCamera_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceToCamera = (vtkDistanceToCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceToCamera.Register(null);
				}
			}
			return vtkDistanceToCamera;
		}

		// Token: 0x06014A80 RID: 84608
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_ScalingOff_13(HandleRef pThis);

		/// <summary>
		/// Whether to scale the distance by the input array to process.
		/// </summary>
		// Token: 0x06014A81 RID: 84609 RVA: 0x001D3F4F File Offset: 0x001D214F
		public virtual void ScalingOff()
		{
			vtkDistanceToCamera.vtkDistanceToCamera_ScalingOff_13(base.GetCppThis());
		}

		// Token: 0x06014A82 RID: 84610
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_ScalingOn_14(HandleRef pThis);

		/// <summary>
		/// Whether to scale the distance by the input array to process.
		/// </summary>
		// Token: 0x06014A83 RID: 84611 RVA: 0x001D3F5E File Offset: 0x001D215E
		public virtual void ScalingOn()
		{
			vtkDistanceToCamera.vtkDistanceToCamera_ScalingOn_14(base.GetCppThis());
		}

		// Token: 0x06014A84 RID: 84612
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_SetDistanceArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the distance array. If not set, the array is
		/// named 'DistanceToCamera'.
		/// </summary>
		// Token: 0x06014A85 RID: 84613 RVA: 0x001D3F6D File Offset: 0x001D216D
		public virtual void SetDistanceArrayName(string _arg)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetDistanceArrayName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06014A86 RID: 84614
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_SetRenderer_16(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// The renderer which will ultimately render these points.
		/// </summary>
		// Token: 0x06014A87 RID: 84615 RVA: 0x001D3F80 File Offset: 0x001D2180
		public void SetRenderer(vtkRenderer ren)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetRenderer_16(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014A88 RID: 84616
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_SetScaling_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to scale the distance by the input array to process.
		/// </summary>
		// Token: 0x06014A89 RID: 84617 RVA: 0x001D3FAF File Offset: 0x001D21AF
		public virtual void SetScaling(bool _arg)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetScaling_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014A8A RID: 84618
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceToCamera_SetScreenSize_18(HandleRef pThis, double _arg);

		/// <summary>
		/// The desired screen size obtained by scaling glyphs by the distance
		/// array. It assumes the glyph at each point will be unit size.
		/// </summary>
		// Token: 0x06014A8B RID: 84619 RVA: 0x001D3FC7 File Offset: 0x001D21C7
		public virtual void SetScreenSize(double _arg)
		{
			vtkDistanceToCamera.vtkDistanceToCamera_SetScreenSize_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DC RID: 6108
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceToCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017DD RID: 6109
		public new static readonly string MRClassNameKey = "class vtkDistanceToCamera";
	}
}
