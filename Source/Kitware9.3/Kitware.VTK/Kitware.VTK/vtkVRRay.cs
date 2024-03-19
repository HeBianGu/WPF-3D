using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRRay
	/// </summary>
	/// <remarks>
	///    VR device model
	///
	/// Represents a ray shooting from a VR controller, used for pointing or picking.
	/// </remarks>
	// Token: 0x020000C9 RID: 201
	public class vtkVRRay : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002B1E RID: 11038 RVA: 0x0003FB27 File Offset: 0x0003DD27
		static vtkVRRay()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRRay.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRay"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002B1F RID: 11039 RVA: 0x0003FB4F File Offset: 0x0003DD4F
		public vtkVRRay(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002B20 RID: 11040
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRay_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B21 RID: 11041 RVA: 0x0003FB60 File Offset: 0x0003DD60
		public new static vtkVRRay New()
		{
			vtkVRRay result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRay.vtkVRRay_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRRay)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B22 RID: 11042 RVA: 0x0003FBB4 File Offset: 0x0003DDB4
		public vtkVRRay() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRRay.vtkVRRay_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002B23 RID: 11043 RVA: 0x0003FBF8 File Offset: 0x0003DDF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002B24 RID: 11044
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRay_Build_01(HandleRef pThis, HandleRef win);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B25 RID: 11045 RVA: 0x0003FC04 File Offset: 0x0003DE04
		public bool Build(vtkOpenGLRenderWindow win)
		{
			return vtkVRRay.vtkVRRay_Build_01(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis()) != 0;
		}

		// Token: 0x06002B26 RID: 11046
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRay_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B27 RID: 11047 RVA: 0x0003FC40 File Offset: 0x0003DE40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRRay.vtkVRRay_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002B28 RID: 11048
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRay_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B29 RID: 11049 RVA: 0x0003FC60 File Offset: 0x0003DE60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRRay.vtkVRRay_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002B2A RID: 11050
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRay_GetShow_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B2B RID: 11051 RVA: 0x0003FC7C File Offset: 0x0003DE7C
		public virtual bool GetShow()
		{
			return vtkVRRay.vtkVRRay_GetShow_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06002B2C RID: 11052
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRay_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B2D RID: 11053 RVA: 0x0003FCA4 File Offset: 0x0003DEA4
		public override int IsA(string type)
		{
			return vtkVRRay.vtkVRRay_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002B2E RID: 11054
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRay_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B2F RID: 11055 RVA: 0x0003FCC4 File Offset: 0x0003DEC4
		public new static int IsTypeOf(string type)
		{
			return vtkVRRay.vtkVRRay_IsTypeOf_06(type);
		}

		// Token: 0x06002B30 RID: 11056
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRay_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B31 RID: 11057 RVA: 0x0003FCE0 File Offset: 0x0003DEE0
		public new vtkVRRay NewInstance()
		{
			vtkVRRay result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRay.vtkVRRay_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRRay)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002B32 RID: 11058
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef win);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B33 RID: 11059 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		public void ReleaseGraphicsResources(vtkRenderWindow win)
		{
			vtkVRRay.vtkVRRay_ReleaseGraphicsResources_09(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06002B34 RID: 11060
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_Render_10(HandleRef pThis, HandleRef win, HandleRef poseMatrix);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B35 RID: 11061 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		public void Render(vtkOpenGLRenderWindow win, vtkMatrix4x4 poseMatrix)
		{
			vtkVRRay.vtkVRRay_Render_10(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis());
		}

		// Token: 0x06002B36 RID: 11062
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRay_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B37 RID: 11063 RVA: 0x0003FDB0 File Offset: 0x0003DFB0
		public new static vtkVRRay SafeDownCast(vtkObjectBase o)
		{
			vtkVRRay vtkVRRay = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRay.vtkVRRay_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRRay = (vtkVRRay)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRRay.Register(null);
				}
			}
			return vtkVRRay;
		}

		// Token: 0x06002B38 RID: 11064
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_SetColor_12(HandleRef pThis, float _arg1, float _arg2, float _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B39 RID: 11065 RVA: 0x0003FE2F File Offset: 0x0003E02F
		public virtual void SetColor(float _arg1, float _arg2, float _arg3)
		{
			vtkVRRay.vtkVRRay_SetColor_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06002B3A RID: 11066
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_SetColor_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B3B RID: 11067 RVA: 0x0003FE41 File Offset: 0x0003E041
		public virtual void SetColor(IntPtr _arg)
		{
			vtkVRRay.vtkVRRay_SetColor_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06002B3C RID: 11068
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_SetLength_14(HandleRef pThis, float _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B3D RID: 11069 RVA: 0x0003FE51 File Offset: 0x0003E051
		public virtual void SetLength(float _arg)
		{
			vtkVRRay.vtkVRRay_SetLength_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06002B3E RID: 11070
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRay_SetShow_15(HandleRef pThis, byte _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002B3F RID: 11071 RVA: 0x0003FE61 File Offset: 0x0003E061
		public virtual void SetShow(bool _arg)
		{
			vtkVRRay.vtkVRRay_SetShow_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000584 RID: 1412
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRRay";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000585 RID: 1413
		public new static readonly string MRClassNameKey = "class vtkVRRay";
	}
}
