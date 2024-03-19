using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPSphereSource
	/// </summary>
	/// <remarks>
	///    sphere source that supports pieces
	/// </remarks>
	// Token: 0x02000533 RID: 1331
	public class vtkPSphereSource : vtkSphereSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EDAF RID: 60847 RVA: 0x0014B449 File Offset: 0x00149649
		static vtkPSphereSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPSphereSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDB0 RID: 60848 RVA: 0x0014B471 File Offset: 0x00149671
		public vtkPSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EDB1 RID: 60849
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
		/// </summary>
		// Token: 0x0600EDB2 RID: 60850 RVA: 0x0014B480 File Offset: 0x00149680
		public new static vtkPSphereSource New()
		{
			vtkPSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct sphere with radius=0.5 and default resolution 8 in both Phi
		/// and Theta directions. Theta ranges from (0,360) and phi (0,180) degrees.
		/// </summary>
		// Token: 0x0600EDB3 RID: 60851 RVA: 0x0014B4D4 File Offset: 0x001496D4
		public vtkPSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPSphereSource.vtkPSphereSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDB4 RID: 60852 RVA: 0x0014B518 File Offset: 0x00149718
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EDB5 RID: 60853
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPSphereSource_GetEstimatedMemorySize_01(HandleRef pThis);

		/// <summary>
		/// Get the estimated memory size in kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x0600EDB6 RID: 60854 RVA: 0x0014B524 File Offset: 0x00149724
		public uint GetEstimatedMemorySize()
		{
			return vtkPSphereSource.vtkPSphereSource_GetEstimatedMemorySize_01(base.GetCppThis());
		}

		// Token: 0x0600EDB7 RID: 60855
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPSphereSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDB8 RID: 60856 RVA: 0x0014B544 File Offset: 0x00149744
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600EDB9 RID: 60857
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPSphereSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDBA RID: 60858 RVA: 0x0014B564 File Offset: 0x00149764
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600EDBB RID: 60859
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPSphereSource_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDBC RID: 60860 RVA: 0x0014B580 File Offset: 0x00149780
		public override int IsA(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EDBD RID: 60861
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPSphereSource_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDBE RID: 60862 RVA: 0x0014B5A0 File Offset: 0x001497A0
		public new static int IsTypeOf(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_IsTypeOf_05(type);
		}

		// Token: 0x0600EDBF RID: 60863
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSphereSource_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDC0 RID: 60864 RVA: 0x0014B5BC File Offset: 0x001497BC
		public new vtkPSphereSource NewInstance()
		{
			vtkPSphereSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EDC1 RID: 60865
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPSphereSource_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDC2 RID: 60866 RVA: 0x0014B618 File Offset: 0x00149818
		public new static vtkPSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkPSphereSource vtkPSphereSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPSphereSource = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPSphereSource.Register(null);
				}
			}
			return vtkPSphereSource;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115E RID: 4446
		public new const string MRFullTypeName = "Kitware.VTK.vtkPSphereSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400115F RID: 4447
		public new static readonly string MRClassNameKey = "class vtkPSphereSource";
	}
}
