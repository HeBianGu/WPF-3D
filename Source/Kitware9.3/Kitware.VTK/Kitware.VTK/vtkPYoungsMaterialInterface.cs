using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPYoungsMaterialInterface
	/// </summary>
	/// <remarks>
	///    parallel reconstruction of material interfaces
	///
	///
	/// This is a subclass of vtkYoungsMaterialInterface, implementing the reconstruction
	/// of material interfaces, for parallel data sets
	///
	/// @par Thanks:
	/// This file is part of the generalized Youngs material interface reconstruction algorithm
	/// contributed by &lt;br&gt; CEA/DIF - Commissariat a l'Energie Atomique, Centre DAM Ile-De-France &lt;br&gt;
	/// BP12, F-91297 Arpajon, France. &lt;br&gt;
	/// Implementation by Thierry Carrard and Philippe Pebay
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkYoungsMaterialInterface
	/// </seealso>
	// Token: 0x02000538 RID: 1336
	public class vtkPYoungsMaterialInterface : vtkYoungsMaterialInterface
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EE6D RID: 61037 RVA: 0x0014C215 File Offset: 0x0014A415
		static vtkPYoungsMaterialInterface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPYoungsMaterialInterface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPYoungsMaterialInterface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE6E RID: 61038 RVA: 0x0014C23D File Offset: 0x0014A43D
		public vtkPYoungsMaterialInterface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EE6F RID: 61039
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPYoungsMaterialInterface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE70 RID: 61040 RVA: 0x0014C24C File Offset: 0x0014A44C
		public new static vtkPYoungsMaterialInterface New()
		{
			vtkPYoungsMaterialInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE71 RID: 61041 RVA: 0x0014C2A0 File Offset: 0x0014A4A0
		public vtkPYoungsMaterialInterface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE72 RID: 61042 RVA: 0x0014C2E4 File Offset: 0x0014A4E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EE73 RID: 61043
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPYoungsMaterialInterface_Aggregate_01(HandleRef pThis, int arg0, IntPtr arg1);

		/// <summary>
		/// Parallel implementation of the material aggregation.
		/// </summary>
		// Token: 0x0600EE74 RID: 61044 RVA: 0x0014C2EF File Offset: 0x0014A4EF
		public virtual void Aggregate(int arg0, IntPtr arg1)
		{
			vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_Aggregate_01(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600EE75 RID: 61045
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPYoungsMaterialInterface_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the multiprocess controller. If no controller is set,
		/// single process is assumed.
		/// </summary>
		// Token: 0x0600EE76 RID: 61046 RVA: 0x0014C300 File Offset: 0x0014A500
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_GetController_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600EE77 RID: 61047
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPYoungsMaterialInterface_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE78 RID: 61048 RVA: 0x0014C370 File Offset: 0x0014A570
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EE79 RID: 61049
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE7A RID: 61050 RVA: 0x0014C390 File Offset: 0x0014A590
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600EE7B RID: 61051
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPYoungsMaterialInterface_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE7C RID: 61052 RVA: 0x0014C3AC File Offset: 0x0014A5AC
		public override int IsA(string type)
		{
			return vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600EE7D RID: 61053
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPYoungsMaterialInterface_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE7E RID: 61054 RVA: 0x0014C3CC File Offset: 0x0014A5CC
		public new static int IsTypeOf(string type)
		{
			return vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_IsTypeOf_06(type);
		}

		// Token: 0x0600EE7F RID: 61055
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPYoungsMaterialInterface_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE80 RID: 61056 RVA: 0x0014C3E8 File Offset: 0x0014A5E8
		public new vtkPYoungsMaterialInterface NewInstance()
		{
			vtkPYoungsMaterialInterface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EE81 RID: 61057
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPYoungsMaterialInterface_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE82 RID: 61058 RVA: 0x0014C444 File Offset: 0x0014A644
		public new static vtkPYoungsMaterialInterface SafeDownCast(vtkObjectBase o)
		{
			vtkPYoungsMaterialInterface vtkPYoungsMaterialInterface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPYoungsMaterialInterface = (vtkPYoungsMaterialInterface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPYoungsMaterialInterface.Register(null);
				}
			}
			return vtkPYoungsMaterialInterface;
		}

		// Token: 0x0600EE83 RID: 61059
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPYoungsMaterialInterface_SetController_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the multiprocess controller. If no controller is set,
		/// single process is assumed.
		/// </summary>
		// Token: 0x0600EE84 RID: 61060 RVA: 0x0014C4C4 File Offset: 0x0014A6C4
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPYoungsMaterialInterface.vtkPYoungsMaterialInterface_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001168 RID: 4456
		public new const string MRFullTypeName = "Kitware.VTK.vtkPYoungsMaterialInterface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001169 RID: 4457
		public new static readonly string MRClassNameKey = "class vtkPYoungsMaterialInterface";
	}
}
