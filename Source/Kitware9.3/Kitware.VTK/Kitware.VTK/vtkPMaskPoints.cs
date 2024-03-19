using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPMaskPoints
	/// </summary>
	/// <remarks>
	///    parallel Mask Points
	///
	/// The difference between this implementation and vtkMaskPoints is
	/// the use of the vtkMultiProcessController and that
	/// ProportionalMaximumNumberOfPoints is obeyed.
	/// </remarks>
	// Token: 0x0200051E RID: 1310
	public class vtkPMaskPoints : vtkMaskPoints
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EAC0 RID: 60096 RVA: 0x0014740D File Offset: 0x0014560D
		static vtkPMaskPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPMaskPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPMaskPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAC1 RID: 60097 RVA: 0x00147435 File Offset: 0x00145635
		public vtkPMaskPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EAC2 RID: 60098
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMaskPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00147444 File Offset: 0x00145644
		public new static vtkPMaskPoints New()
		{
			vtkPMaskPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMaskPoints.vtkPMaskPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00147498 File Offset: 0x00145698
		public vtkPMaskPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPMaskPoints.vtkPMaskPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAC5 RID: 60101 RVA: 0x001474DC File Offset: 0x001456DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EAC6 RID: 60102
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMaskPoints_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the communicator object for interprocess communication
		/// </summary>
		// Token: 0x0600EAC7 RID: 60103 RVA: 0x001474E8 File Offset: 0x001456E8
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMaskPoints.vtkPMaskPoints_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600EAC8 RID: 60104
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPMaskPoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00147558 File Offset: 0x00145758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPMaskPoints.vtkPMaskPoints_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600EACA RID: 60106
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPMaskPoints_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EACB RID: 60107 RVA: 0x00147578 File Offset: 0x00145778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPMaskPoints.vtkPMaskPoints_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600EACC RID: 60108
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPMaskPoints_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EACD RID: 60109 RVA: 0x00147594 File Offset: 0x00145794
		public override int IsA(string type)
		{
			return vtkPMaskPoints.vtkPMaskPoints_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EACE RID: 60110
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPMaskPoints_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EACF RID: 60111 RVA: 0x001475B4 File Offset: 0x001457B4
		public new static int IsTypeOf(string type)
		{
			return vtkPMaskPoints.vtkPMaskPoints_IsTypeOf_05(type);
		}

		// Token: 0x0600EAD0 RID: 60112
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMaskPoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAD1 RID: 60113 RVA: 0x001475D0 File Offset: 0x001457D0
		public new vtkPMaskPoints NewInstance()
		{
			vtkPMaskPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMaskPoints.vtkPMaskPoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EAD2 RID: 60114
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMaskPoints_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAD3 RID: 60115 RVA: 0x0014762C File Offset: 0x0014582C
		public new static vtkPMaskPoints SafeDownCast(vtkObjectBase o)
		{
			vtkPMaskPoints vtkPMaskPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMaskPoints.vtkPMaskPoints_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPMaskPoints = (vtkPMaskPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPMaskPoints.Register(null);
				}
			}
			return vtkPMaskPoints;
		}

		// Token: 0x0600EAD4 RID: 60116
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPMaskPoints_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the communicator object for interprocess communication
		/// </summary>
		// Token: 0x0600EAD5 RID: 60117 RVA: 0x001476AC File Offset: 0x001458AC
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPMaskPoints.vtkPMaskPoints_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400112B RID: 4395
		public new const string MRFullTypeName = "Kitware.VTK.vtkPMaskPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400112C RID: 4396
		public new static readonly string MRClassNameKey = "class vtkPMaskPoints";
	}
}
