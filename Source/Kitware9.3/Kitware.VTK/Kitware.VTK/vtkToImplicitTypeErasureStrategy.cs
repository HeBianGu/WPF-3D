using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToImplicitTypeErasureStrategy
	///
	/// A strategy for compressing arrays by type when applicable (int -&gt; unsigned char for example) and
	/// wrapping them behind a `vtkImplicitArray` to furnish the same interface.
	///
	/// Arrays are able to be compressed when they are integral and their range (`max_val - min_val`) is
	/// able to be represented in a type that takes less memory than the original type. For example, a
	/// `vtkIntArray` with minimum `342` and maximum `416` has a range of `74` and can therefore be
	/// represented by its minimal value and an array of differences stored as `char`s.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkImplicitArray vtkToImplicitArrayFilter vtkToImplicitStrategy
	/// </seealso>
	// Token: 0x0200042B RID: 1067
	public class vtkToImplicitTypeErasureStrategy : vtkToImplicitStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C867 RID: 51303 RVA: 0x00117037 File Offset: 0x00115237
		static vtkToImplicitTypeErasureStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToImplicitTypeErasureStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToImplicitTypeErasureStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C868 RID: 51304 RVA: 0x0011705F File Offset: 0x0011525F
		public vtkToImplicitTypeErasureStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C869 RID: 51305
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitTypeErasureStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C86A RID: 51306 RVA: 0x00117070 File Offset: 0x00115270
		public new static vtkToImplicitTypeErasureStrategy New()
		{
			vtkToImplicitTypeErasureStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitTypeErasureStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C86B RID: 51307 RVA: 0x001170C4 File Offset: 0x001152C4
		public vtkToImplicitTypeErasureStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C86C RID: 51308 RVA: 0x00117108 File Offset: 0x00115308
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C86D RID: 51309
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitTypeErasureStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C86E RID: 51310 RVA: 0x00117114 File Offset: 0x00115314
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C86F RID: 51311
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitTypeErasureStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C870 RID: 51312 RVA: 0x00117134 File Offset: 0x00115334
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C871 RID: 51313
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitTypeErasureStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C872 RID: 51314 RVA: 0x00117150 File Offset: 0x00115350
		public override int IsA(string type)
		{
			return vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C873 RID: 51315
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitTypeErasureStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C874 RID: 51316 RVA: 0x00117170 File Offset: 0x00115370
		public new static int IsTypeOf(string type)
		{
			return vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_IsTypeOf_04(type);
		}

		// Token: 0x0600C875 RID: 51317
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitTypeErasureStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C876 RID: 51318 RVA: 0x0011718C File Offset: 0x0011538C
		public new vtkToImplicitTypeErasureStrategy NewInstance()
		{
			vtkToImplicitTypeErasureStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitTypeErasureStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C877 RID: 51319
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitTypeErasureStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C878 RID: 51320 RVA: 0x001171E8 File Offset: 0x001153E8
		public new static vtkToImplicitTypeErasureStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkToImplicitTypeErasureStrategy vtkToImplicitTypeErasureStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitTypeErasureStrategy.vtkToImplicitTypeErasureStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToImplicitTypeErasureStrategy = (vtkToImplicitTypeErasureStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToImplicitTypeErasureStrategy.Register(null);
				}
			}
			return vtkToImplicitTypeErasureStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE7 RID: 3815
		public new const string MRFullTypeName = "Kitware.VTK.vtkToImplicitTypeErasureStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE8 RID: 3816
		public new static readonly string MRClassNameKey = "class vtkToImplicitTypeErasureStrategy";
	}
}
