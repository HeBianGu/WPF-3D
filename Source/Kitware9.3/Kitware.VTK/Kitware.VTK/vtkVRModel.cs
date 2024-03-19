using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRModel
	/// </summary>
	/// <remarks>
	///    VR device model
	///
	/// Abstract class used to load models
	/// such as for the trackers and controllers and to
	/// render them in the scene
	///
	/// </remarks>
	// Token: 0x020000A8 RID: 168
	public abstract class vtkVRModel : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060023C5 RID: 9157 RVA: 0x000359A3 File Offset: 0x00033BA3
		static vtkVRModel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRModel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRModel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060023C6 RID: 9158 RVA: 0x000359CB File Offset: 0x00033BCB
		public vtkVRModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060023C7 RID: 9159 RVA: 0x000359D9 File Offset: 0x00033BD9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060023C8 RID: 9160
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRModel_Build_01(HandleRef pThis, HandleRef win);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023C9 RID: 9161 RVA: 0x000359E4 File Offset: 0x00033BE4
		public bool Build(vtkOpenGLRenderWindow win)
		{
			return vtkVRModel.vtkVRModel_Build_01(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis()) != 0;
		}

		// Token: 0x060023CA RID: 9162
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVRModel_GetName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023CB RID: 9163 RVA: 0x00035A20 File Offset: 0x00033C20
		public string GetName()
		{
			return vtkVRModel.vtkVRModel_GetName_02(base.GetCppThis());
		}

		// Token: 0x060023CC RID: 9164
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRModel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023CD RID: 9165 RVA: 0x00035A40 File Offset: 0x00033C40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRModel.vtkVRModel_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060023CE RID: 9166
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRModel_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023CF RID: 9167 RVA: 0x00035A60 File Offset: 0x00033C60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRModel.vtkVRModel_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060023D0 RID: 9168
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRModel_GetRay_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023D1 RID: 9169 RVA: 0x00035A7C File Offset: 0x00033C7C
		public vtkVRRay GetRay()
		{
			vtkVRRay vtkVRRay = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRModel.vtkVRModel_GetRay_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060023D2 RID: 9170
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRModel_GetVisibility_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023D3 RID: 9171 RVA: 0x00035AEC File Offset: 0x00033CEC
		public bool GetVisibility()
		{
			return vtkVRModel.vtkVRModel_GetVisibility_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060023D4 RID: 9172
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRModel_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023D5 RID: 9173 RVA: 0x00035B14 File Offset: 0x00033D14
		public override int IsA(string type)
		{
			return vtkVRModel.vtkVRModel_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060023D6 RID: 9174
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRModel_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023D7 RID: 9175 RVA: 0x00035B34 File Offset: 0x00033D34
		public new static int IsTypeOf(string type)
		{
			return vtkVRModel.vtkVRModel_IsTypeOf_08(type);
		}

		// Token: 0x060023D8 RID: 9176
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRModel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023D9 RID: 9177 RVA: 0x00035B50 File Offset: 0x00033D50
		public new vtkVRModel NewInstance()
		{
			vtkVRModel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRModel.vtkVRModel_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060023DA RID: 9178
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023DB RID: 9179 RVA: 0x00035BAC File Offset: 0x00033DAC
		public void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkVRModel.vtkVRModel_ReleaseGraphicsResources_10(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x060023DC RID: 9180
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_Render_11(HandleRef pThis, HandleRef win, HandleRef poseInTrackingCoordinates);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023DD RID: 9181 RVA: 0x00035BDC File Offset: 0x00033DDC
		public void Render(vtkOpenGLRenderWindow win, vtkMatrix4x4 poseInTrackingCoordinates)
		{
			vtkVRModel.vtkVRModel_Render_11(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis(), (poseInTrackingCoordinates == null) ? default(HandleRef) : poseInTrackingCoordinates.GetCppThis());
		}

		// Token: 0x060023DE RID: 9182
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRModel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023DF RID: 9183 RVA: 0x00035C20 File Offset: 0x00033E20
		public new static vtkVRModel SafeDownCast(vtkObjectBase o)
		{
			vtkVRModel vtkVRModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRModel.vtkVRModel_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRModel = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRModel.Register(null);
				}
			}
			return vtkVRModel;
		}

		// Token: 0x060023E0 RID: 9184
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_SetName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string modelName);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023E1 RID: 9185 RVA: 0x00035C9F File Offset: 0x00033E9F
		public void SetName(string modelName)
		{
			vtkVRModel.vtkVRModel_SetName_13(base.GetCppThis(), modelName);
		}

		// Token: 0x060023E2 RID: 9186
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_SetRayColor_14(HandleRef pThis, double r, double g, double b);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023E3 RID: 9187 RVA: 0x00035CAF File Offset: 0x00033EAF
		public void SetRayColor(double r, double g, double b)
		{
			vtkVRModel.vtkVRModel_SetRayColor_14(base.GetCppThis(), r, g, b);
		}

		// Token: 0x060023E4 RID: 9188
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_SetRayLength_15(HandleRef pThis, double length);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023E5 RID: 9189 RVA: 0x00035CC1 File Offset: 0x00033EC1
		public void SetRayLength(double length)
		{
			vtkVRModel.vtkVRModel_SetRayLength_15(base.GetCppThis(), length);
		}

		// Token: 0x060023E6 RID: 9190
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_SetShowRay_16(HandleRef pThis, byte v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023E7 RID: 9191 RVA: 0x00035CD1 File Offset: 0x00033ED1
		public void SetShowRay(bool v)
		{
			vtkVRModel.vtkVRModel_SetShowRay_16(base.GetCppThis(), v ? (byte)1 : (byte)0);
		}

		// Token: 0x060023E8 RID: 9192
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRModel_SetVisibility_17(HandleRef pThis, byte v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060023E9 RID: 9193 RVA: 0x00035CE9 File Offset: 0x00033EE9
		public void SetVisibility(bool v)
		{
			vtkVRModel.vtkVRModel_SetVisibility_17(base.GetCppThis(), v ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000533 RID: 1331
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRModel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000534 RID: 1332
		public new static readonly string MRClassNameKey = "class vtkVRModel";
	}
}
