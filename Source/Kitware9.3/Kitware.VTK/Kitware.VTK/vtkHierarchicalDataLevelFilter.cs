using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalDataLevelFilter
	/// </summary>
	/// <remarks>
	///    generate scalars from levels
	///
	/// Legacy class. Use vtkLevelIdScalars instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLevelIdScalars
	/// </seealso>
	// Token: 0x020008AB RID: 2219
	public class vtkHierarchicalDataLevelFilter : vtkLevelIdScalars
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016FD4 RID: 94164 RVA: 0x00204F5F File Offset: 0x0020315F
		static vtkHierarchicalDataLevelFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataLevelFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataLevelFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016FD5 RID: 94165 RVA: 0x00204F87 File Offset: 0x00203187
		public vtkHierarchicalDataLevelFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016FD6 RID: 94166
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x06016FD7 RID: 94167 RVA: 0x00204F98 File Offset: 0x00203198
		public new static vtkHierarchicalDataLevelFilter New()
		{
			vtkHierarchicalDataLevelFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x06016FD8 RID: 94168 RVA: 0x00204FEC File Offset: 0x002031EC
		public vtkHierarchicalDataLevelFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016FD9 RID: 94169 RVA: 0x00205030 File Offset: 0x00203230
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016FDA RID: 94170
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataLevelFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FDB RID: 94171 RVA: 0x0020503C File Offset: 0x0020323C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016FDC RID: 94172
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalDataLevelFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FDD RID: 94173 RVA: 0x0020505C File Offset: 0x0020325C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016FDE RID: 94174
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataLevelFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FDF RID: 94175 RVA: 0x00205078 File Offset: 0x00203278
		public override int IsA(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016FE0 RID: 94176
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalDataLevelFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FE1 RID: 94177 RVA: 0x00205098 File Offset: 0x00203298
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_IsTypeOf_04(type);
		}

		// Token: 0x06016FE2 RID: 94178
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FE3 RID: 94179 RVA: 0x002050B4 File Offset: 0x002032B4
		public new vtkHierarchicalDataLevelFilter NewInstance()
		{
			vtkHierarchicalDataLevelFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016FE4 RID: 94180
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalDataLevelFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FE5 RID: 94181 RVA: 0x00205110 File Offset: 0x00203310
		public new static vtkHierarchicalDataLevelFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataLevelFilter vtkHierarchicalDataLevelFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalDataLevelFilter.vtkHierarchicalDataLevelFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataLevelFilter = (vtkHierarchicalDataLevelFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataLevelFilter.Register(null);
				}
			}
			return vtkHierarchicalDataLevelFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BC RID: 6588
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataLevelFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BD RID: 6589
		public new static readonly string MRClassNameKey = "class vtkHierarchicalDataLevelFilter";
	}
}
