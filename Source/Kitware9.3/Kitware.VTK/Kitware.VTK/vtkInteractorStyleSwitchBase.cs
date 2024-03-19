using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleSwitchBase
	/// </summary>
	/// <remarks>
	///    dummy interface class.
	///
	/// The class vtkInteractorStyleSwitchBase is here to allow the
	/// vtkRenderWindowInteractor to instantiate a default interactor style and
	/// preserve backward compatible behavior when the object factory is overridden
	/// and vtkInteractorStyleSwitch is returned.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyleSwitchBase vtkRenderWindowInteractor
	/// </seealso>
	// Token: 0x02000403 RID: 1027
	public class vtkInteractorStyleSwitchBase : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C389 RID: 50057 RVA: 0x0010FFAB File Offset: 0x0010E1AB
		static vtkInteractorStyleSwitchBase()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleSwitchBase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleSwitchBase"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C38A RID: 50058 RVA: 0x0010FFD3 File Offset: 0x0010E1D3
		public vtkInteractorStyleSwitchBase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C38B RID: 50059
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitchBase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C38C RID: 50060 RVA: 0x0010FFE4 File Offset: 0x0010E1E4
		public new static vtkInteractorStyleSwitchBase New()
		{
			vtkInteractorStyleSwitchBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitchBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C38D RID: 50061 RVA: 0x00110038 File Offset: 0x0010E238
		public vtkInteractorStyleSwitchBase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C38E RID: 50062 RVA: 0x0011007C File Offset: 0x0010E27C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C38F RID: 50063
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitchBase_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C390 RID: 50064 RVA: 0x00110088 File Offset: 0x0010E288
		public override vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x0600C391 RID: 50065
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleSwitchBase_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C392 RID: 50066 RVA: 0x001100F8 File Offset: 0x0010E2F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C393 RID: 50067
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleSwitchBase_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C394 RID: 50068 RVA: 0x00110118 File Offset: 0x0010E318
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C395 RID: 50069
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleSwitchBase_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C396 RID: 50070 RVA: 0x00110134 File Offset: 0x0010E334
		public override int IsA(string type)
		{
			return vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C397 RID: 50071
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleSwitchBase_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C398 RID: 50072 RVA: 0x00110154 File Offset: 0x0010E354
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_IsTypeOf_05(type);
		}

		// Token: 0x0600C399 RID: 50073
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitchBase_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C39A RID: 50074 RVA: 0x00110170 File Offset: 0x0010E370
		public new vtkInteractorStyleSwitchBase NewInstance()
		{
			vtkInteractorStyleSwitchBase result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleSwitchBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C39B RID: 50075
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleSwitchBase_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C39C RID: 50076 RVA: 0x001101CC File Offset: 0x0010E3CC
		public new static vtkInteractorStyleSwitchBase SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleSwitchBase vtkInteractorStyleSwitchBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleSwitchBase.vtkInteractorStyleSwitchBase_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleSwitchBase = (vtkInteractorStyleSwitchBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleSwitchBase.Register(null);
				}
			}
			return vtkInteractorStyleSwitchBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E78 RID: 3704
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleSwitchBase";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E79 RID: 3705
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleSwitchBase";
	}
}
