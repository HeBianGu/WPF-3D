using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToConstantArrayStrategy
	///
	/// Strategy to be used in conjunction with `vtkToImplicitArrayFilter` to identify and compress
	/// constant arrays.
	/// </summary>
	// Token: 0x02000428 RID: 1064
	public class vtkToConstantArrayStrategy : vtkToImplicitStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C80B RID: 51211 RVA: 0x001164BB File Offset: 0x001146BB
		static vtkToConstantArrayStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToConstantArrayStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToConstantArrayStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C80C RID: 51212 RVA: 0x001164E3 File Offset: 0x001146E3
		public vtkToConstantArrayStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C80D RID: 51213
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToConstantArrayStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C80E RID: 51214 RVA: 0x001164F4 File Offset: 0x001146F4
		public new static vtkToConstantArrayStrategy New()
		{
			vtkToConstantArrayStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToConstantArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C80F RID: 51215 RVA: 0x00116548 File Offset: 0x00114748
		public vtkToConstantArrayStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C810 RID: 51216 RVA: 0x0011658C File Offset: 0x0011478C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C811 RID: 51217
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToConstantArrayStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C812 RID: 51218 RVA: 0x00116598 File Offset: 0x00114798
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C813 RID: 51219
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToConstantArrayStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C814 RID: 51220 RVA: 0x001165B8 File Offset: 0x001147B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C815 RID: 51221
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToConstantArrayStrategy_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C816 RID: 51222 RVA: 0x001165D4 File Offset: 0x001147D4
		public override int IsA(string type)
		{
			return vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C817 RID: 51223
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToConstantArrayStrategy_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C818 RID: 51224 RVA: 0x001165F4 File Offset: 0x001147F4
		public new static int IsTypeOf(string type)
		{
			return vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_IsTypeOf_04(type);
		}

		// Token: 0x0600C819 RID: 51225
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToConstantArrayStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C81A RID: 51226 RVA: 0x00116610 File Offset: 0x00114810
		public new vtkToConstantArrayStrategy NewInstance()
		{
			vtkToConstantArrayStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToConstantArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C81B RID: 51227
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToConstantArrayStrategy_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C81C RID: 51228 RVA: 0x0011666C File Offset: 0x0011486C
		public new static vtkToConstantArrayStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkToConstantArrayStrategy vtkToConstantArrayStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToConstantArrayStrategy.vtkToConstantArrayStrategy_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToConstantArrayStrategy = (vtkToConstantArrayStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToConstantArrayStrategy.Register(null);
				}
			}
			return vtkToConstantArrayStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE1 RID: 3809
		public new const string MRFullTypeName = "Kitware.VTK.vtkToConstantArrayStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE2 RID: 3810
		public new static readonly string MRClassNameKey = "class vtkToConstantArrayStrategy";
	}
}
