using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRIBLight
	/// </summary>
	/// <remarks>
	///    RIP Light
	///
	/// vtkRIBLight is a subclass of vtkLight that allows the user to
	/// specify light source shaders and shadow casting lights for use with
	/// RenderMan.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRIBExporter vtkRIBProperty
	/// </seealso>
	// Token: 0x020001F0 RID: 496
	public class vtkRIBLight : vtkLight
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005E26 RID: 24102 RVA: 0x00088881 File Offset: 0x00086A81
		static vtkRIBLight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRIBLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRIBLight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005E27 RID: 24103 RVA: 0x000888A9 File Offset: 0x00086AA9
		public vtkRIBLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005E28 RID: 24104
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E29 RID: 24105 RVA: 0x000888B8 File Offset: 0x00086AB8
		public new static vtkRIBLight New()
		{
			vtkRIBLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E2A RID: 24106 RVA: 0x0008890C File Offset: 0x00086B0C
		public vtkRIBLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRIBLight.vtkRIBLight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005E2B RID: 24107 RVA: 0x00088950 File Offset: 0x00086B50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005E2C RID: 24108
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBLight_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E2D RID: 24109 RVA: 0x0008895C File Offset: 0x00086B5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRIBLight.vtkRIBLight_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005E2E RID: 24110
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRIBLight_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E2F RID: 24111 RVA: 0x0008897C File Offset: 0x00086B7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRIBLight.vtkRIBLight_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005E30 RID: 24112
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBLight_GetShadows_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E31 RID: 24113 RVA: 0x00088998 File Offset: 0x00086B98
		public virtual int GetShadows()
		{
			return vtkRIBLight.vtkRIBLight_GetShadows_03(base.GetCppThis());
		}

		// Token: 0x06005E32 RID: 24114
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBLight_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E33 RID: 24115 RVA: 0x000889B8 File Offset: 0x00086BB8
		public override int IsA(string type)
		{
			return vtkRIBLight.vtkRIBLight_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06005E34 RID: 24116
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRIBLight_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E35 RID: 24117 RVA: 0x000889D8 File Offset: 0x00086BD8
		public new static int IsTypeOf(string type)
		{
			return vtkRIBLight.vtkRIBLight_IsTypeOf_05(type);
		}

		// Token: 0x06005E36 RID: 24118
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBLight_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E37 RID: 24119 RVA: 0x000889F4 File Offset: 0x00086BF4
		public new vtkRIBLight NewInstance()
		{
			vtkRIBLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005E38 RID: 24120
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBLight_Render_08(HandleRef pThis, HandleRef ren, int index);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E39 RID: 24121 RVA: 0x00088A50 File Offset: 0x00086C50
		public override void Render(vtkRenderer ren, int index)
		{
			vtkRIBLight.vtkRIBLight_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), index);
		}

		// Token: 0x06005E3A RID: 24122
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRIBLight_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E3B RID: 24123 RVA: 0x00088A80 File Offset: 0x00086C80
		public new static vtkRIBLight SafeDownCast(vtkObjectBase o)
		{
			vtkRIBLight vtkRIBLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRIBLight.vtkRIBLight_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRIBLight = (vtkRIBLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRIBLight.Register(null);
				}
			}
			return vtkRIBLight;
		}

		// Token: 0x06005E3C RID: 24124
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBLight_SetShadows_10(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E3D RID: 24125 RVA: 0x00088AFF File Offset: 0x00086CFF
		public virtual void SetShadows(int _arg)
		{
			vtkRIBLight.vtkRIBLight_SetShadows_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E3E RID: 24126
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBLight_ShadowsOff_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E3F RID: 24127 RVA: 0x00088B0F File Offset: 0x00086D0F
		public virtual void ShadowsOff()
		{
			vtkRIBLight.vtkRIBLight_ShadowsOff_11(base.GetCppThis());
		}

		// Token: 0x06005E40 RID: 24128
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRIBLight_ShadowsOn_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005E41 RID: 24129 RVA: 0x00088B1E File Offset: 0x00086D1E
		public virtual void ShadowsOn()
		{
			vtkRIBLight.vtkRIBLight_ShadowsOn_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AA RID: 2218
		public new const string MRFullTypeName = "Kitware.VTK.vtkRIBLight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AB RID: 2219
		public new static readonly string MRClassNameKey = "class vtkRIBLight";
	}
}
