using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToAffineArrayStrategy
	///
	/// Strategy to transform an explicit array into a `vtkAffineArray`.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkToImplicitStrategy vtkToImplicitArrayFilter vtkAffineArray
	/// </seealso>
	// Token: 0x02000427 RID: 1063
	public class vtkToAffineArrayStrategy : vtkToImplicitStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C7F9 RID: 51193 RVA: 0x0011628B File Offset: 0x0011448B
		static vtkToAffineArrayStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToAffineArrayStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToAffineArrayStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7FA RID: 51194 RVA: 0x001162B3 File Offset: 0x001144B3
		public vtkToAffineArrayStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C7FB RID: 51195
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToAffineArrayStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7FC RID: 51196 RVA: 0x001162C4 File Offset: 0x001144C4
		public new static vtkToAffineArrayStrategy New()
		{
			vtkToAffineArrayStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToAffineArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7FD RID: 51197 RVA: 0x00116318 File Offset: 0x00114518
		public vtkToAffineArrayStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7FE RID: 51198 RVA: 0x0011635C File Offset: 0x0011455C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C7FF RID: 51199
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToAffineArrayStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C800 RID: 51200 RVA: 0x00116368 File Offset: 0x00114568
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C801 RID: 51201
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToAffineArrayStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C802 RID: 51202 RVA: 0x00116388 File Offset: 0x00114588
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C803 RID: 51203
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToAffineArrayStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C804 RID: 51204 RVA: 0x001163A4 File Offset: 0x001145A4
		public override int IsA(string type)
		{
			return vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C805 RID: 51205
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToAffineArrayStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C806 RID: 51206 RVA: 0x001163C4 File Offset: 0x001145C4
		public new static int IsTypeOf(string type)
		{
			return vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_IsTypeOf_04(type);
		}

		// Token: 0x0600C807 RID: 51207
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToAffineArrayStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C808 RID: 51208 RVA: 0x001163E0 File Offset: 0x001145E0
		public new vtkToAffineArrayStrategy NewInstance()
		{
			vtkToAffineArrayStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToAffineArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C809 RID: 51209
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToAffineArrayStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C80A RID: 51210 RVA: 0x0011643C File Offset: 0x0011463C
		public new static vtkToAffineArrayStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkToAffineArrayStrategy vtkToAffineArrayStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToAffineArrayStrategy.vtkToAffineArrayStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToAffineArrayStrategy = (vtkToAffineArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToAffineArrayStrategy.Register(null);
				}
			}
			return vtkToAffineArrayStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EDF RID: 3807
		public new const string MRFullTypeName = "Kitware.VTK.vtkToAffineArrayStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE0 RID: 3808
		public new static readonly string MRClassNameKey = "class vtkToAffineArrayStrategy";
	}
}
