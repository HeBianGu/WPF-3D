using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTDxInteractorStyleSettings
	/// </summary>
	/// <remarks>
	///    3DConnexion device settings
	///
	///
	/// vtkTDxInteractorStyleSettings defines settings for 3DConnexion device such
	/// as sensitivity, axis filters
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyle vtkRenderWindowInteractor
	/// vtkTDxInteractorStyle
	/// </seealso>
	// Token: 0x02000819 RID: 2073
	public class vtkTDxInteractorStyleSettings : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060154FF RID: 87295 RVA: 0x001E31F3 File Offset: 0x001E13F3
		static vtkTDxInteractorStyleSettings()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyleSettings.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleSettings"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015500 RID: 87296 RVA: 0x001E321B File Offset: 0x001E141B
		public vtkTDxInteractorStyleSettings(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015501 RID: 87297
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015502 RID: 87298 RVA: 0x001E322C File Offset: 0x001E142C
		public new static vtkTDxInteractorStyleSettings New()
		{
			vtkTDxInteractorStyleSettings result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015503 RID: 87299 RVA: 0x001E3280 File Offset: 0x001E1480
		public vtkTDxInteractorStyleSettings() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015504 RID: 87300 RVA: 0x001E32C4 File Offset: 0x001E14C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015505 RID: 87301
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(HandleRef pThis);

		/// <summary>
		/// Sensitivity of the rotation angle. This can be any value:
		/// positive, negative, null.
		/// - x&lt;-1.0: faster reversed
		/// - x=-1.0: reversed neutral
		/// - -1.0&lt;x&lt;0.0:  reversed slower
		/// - x=0.0: no rotation
		/// - 0.0&lt;x&lt;1.0: slower
		/// - x=1.0: neutral
		/// - x&gt;1.0: faster
		/// </summary>
		// Token: 0x06015506 RID: 87302 RVA: 0x001E32D0 File Offset: 0x001E14D0
		public virtual double GetAngleSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(base.GetCppThis());
		}

		// Token: 0x06015507 RID: 87303
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015508 RID: 87304 RVA: 0x001E32F0 File Offset: 0x001E14F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06015509 RID: 87305
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601550A RID: 87306 RVA: 0x001E3310 File Offset: 0x001E1510
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601550B RID: 87307
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_04(HandleRef pThis);

		/// <summary>
		/// Sensitivity of the translation along the X-axis. This can be any value:
		/// positive, negative, null.
		/// - x&lt;-1.0: faster reversed
		/// - x=-1.0: reversed neutral
		/// - -1.0&lt;x&lt;0.0:  reversed slower
		/// - x=0.0: no translation
		/// - 0.0&lt;x&lt;1.0: slower
		/// - x=1.0: neutral
		/// - x&gt;1.0: faster
		/// Initial value is 1.0
		/// </summary>
		// Token: 0x0601550C RID: 87308 RVA: 0x001E332C File Offset: 0x001E152C
		public virtual double GetTranslationXSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_04(base.GetCppThis());
		}

		// Token: 0x0601550D RID: 87309
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_05(HandleRef pThis);

		/// <summary>
		/// Sensitivity of the translation along the Y-axis.
		/// See comment of SetTranslationXSensitivity().
		/// </summary>
		// Token: 0x0601550E RID: 87310 RVA: 0x001E334C File Offset: 0x001E154C
		public virtual double GetTranslationYSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_05(base.GetCppThis());
		}

		// Token: 0x0601550F RID: 87311
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_06(HandleRef pThis);

		/// <summary>
		/// Sensitivity of the translation along the Z-axis.
		/// See comment of SetTranslationXSensitivity().
		/// </summary>
		// Token: 0x06015510 RID: 87312 RVA: 0x001E336C File Offset: 0x001E156C
		public virtual double GetTranslationZSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_06(base.GetCppThis());
		}

		// Token: 0x06015511 RID: 87313
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationX_07(HandleRef pThis);

		/// <summary>
		/// Use or mask the rotation component around the X-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x06015512 RID: 87314 RVA: 0x001E338C File Offset: 0x001E158C
		public virtual bool GetUseRotationX()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationX_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06015513 RID: 87315
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationY_08(HandleRef pThis);

		/// <summary>
		/// Use or mask the rotation component around the Y-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x06015514 RID: 87316 RVA: 0x001E33B4 File Offset: 0x001E15B4
		public virtual bool GetUseRotationY()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationY_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06015515 RID: 87317
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationZ_09(HandleRef pThis);

		/// <summary>
		/// Use or mask the rotation component around the Z-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x06015516 RID: 87318 RVA: 0x001E33DC File Offset: 0x001E15DC
		public virtual bool GetUseRotationZ()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationZ_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06015517 RID: 87319
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyleSettings_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015518 RID: 87320 RVA: 0x001E3404 File Offset: 0x001E1604
		public override int IsA(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06015519 RID: 87321
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyleSettings_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601551A RID: 87322 RVA: 0x001E3424 File Offset: 0x001E1624
		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_IsTypeOf_11(type);
		}

		// Token: 0x0601551B RID: 87323
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601551C RID: 87324 RVA: 0x001E3440 File Offset: 0x001E1640
		public new vtkTDxInteractorStyleSettings NewInstance()
		{
			vtkTDxInteractorStyleSettings result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601551D RID: 87325
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601551E RID: 87326 RVA: 0x001E349C File Offset: 0x001E169C
		public new static vtkTDxInteractorStyleSettings SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleSettings = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleSettings.Register(null);
				}
			}
			return vtkTDxInteractorStyleSettings;
		}

		// Token: 0x0601551F RID: 87327
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetAngleSensitivity_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Sensitivity of the rotation angle. This can be any value:
		/// positive, negative, null.
		/// - x&lt;-1.0: faster reversed
		/// - x=-1.0: reversed neutral
		/// - -1.0&lt;x&lt;0.0:  reversed slower
		/// - x=0.0: no rotation
		/// - 0.0&lt;x&lt;1.0: slower
		/// - x=1.0: neutral
		/// - x&gt;1.0: faster
		/// </summary>
		// Token: 0x06015520 RID: 87328 RVA: 0x001E351B File Offset: 0x001E171B
		public virtual void SetAngleSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetAngleSensitivity_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06015521 RID: 87329
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Sensitivity of the translation along the X-axis. This can be any value:
		/// positive, negative, null.
		/// - x&lt;-1.0: faster reversed
		/// - x=-1.0: reversed neutral
		/// - -1.0&lt;x&lt;0.0:  reversed slower
		/// - x=0.0: no translation
		/// - 0.0&lt;x&lt;1.0: slower
		/// - x=1.0: neutral
		/// - x&gt;1.0: faster
		/// Initial value is 1.0
		/// </summary>
		// Token: 0x06015522 RID: 87330 RVA: 0x001E352B File Offset: 0x001E172B
		public virtual void SetTranslationXSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06015523 RID: 87331
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Sensitivity of the translation along the Y-axis.
		/// See comment of SetTranslationXSensitivity().
		/// </summary>
		// Token: 0x06015524 RID: 87332 RVA: 0x001E353B File Offset: 0x001E173B
		public virtual void SetTranslationYSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06015525 RID: 87333
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Sensitivity of the translation along the Z-axis.
		/// See comment of SetTranslationXSensitivity().
		/// </summary>
		// Token: 0x06015526 RID: 87334 RVA: 0x001E354B File Offset: 0x001E174B
		public virtual void SetTranslationZSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06015527 RID: 87335
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationX_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use or mask the rotation component around the X-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x06015528 RID: 87336 RVA: 0x001E355B File Offset: 0x001E175B
		public virtual void SetUseRotationX(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationX_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015529 RID: 87337
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationY_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use or mask the rotation component around the Y-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x0601552A RID: 87338 RVA: 0x001E3573 File Offset: 0x001E1773
		public virtual void SetUseRotationY(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationY_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601552B RID: 87339
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationZ_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// Use or mask the rotation component around the Z-axis. Initial value is
		/// true.
		/// </summary>
		// Token: 0x0601552C RID: 87340 RVA: 0x001E358B File Offset: 0x001E178B
		public virtual void SetUseRotationZ(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationZ_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187A RID: 6266
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleSettings";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187B RID: 6267
		public new static readonly string MRClassNameKey = "class vtkTDxInteractorStyleSettings";
	}
}
