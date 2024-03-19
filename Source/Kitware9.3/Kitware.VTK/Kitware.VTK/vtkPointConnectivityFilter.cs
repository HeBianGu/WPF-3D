using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointConnectivityFilter
	/// </summary>
	/// <remarks>
	///    output a scalar field indicating point connectivity
	///
	///
	/// vtkPointConnectivityFilter is a filter the produces a point scalar field
	/// that characerizes the connectivity of the point. What is meant by
	/// connectivity is the number of cells that use each point. The output
	/// scalar array is represented by a 16-bit integral value. A value of zero
	/// means that no cells use a particular point.
	/// </remarks>
	// Token: 0x020008C9 RID: 2249
	public class vtkPointConnectivityFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017404 RID: 95236 RVA: 0x0020A577 File Offset: 0x00208777
		static vtkPointConnectivityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointConnectivityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017405 RID: 95237 RVA: 0x0020A59F File Offset: 0x0020879F
		public vtkPointConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017406 RID: 95238
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x06017407 RID: 95239 RVA: 0x0020A5B0 File Offset: 0x002087B0
		public new static vtkPointConnectivityFilter New()
		{
			vtkPointConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointConnectivityFilter.vtkPointConnectivityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x06017408 RID: 95240 RVA: 0x0020A604 File Offset: 0x00208804
		public vtkPointConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointConnectivityFilter.vtkPointConnectivityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017409 RID: 95241 RVA: 0x0020A648 File Offset: 0x00208848
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601740A RID: 95242
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointConnectivityFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x0601740B RID: 95243 RVA: 0x0020A654 File Offset: 0x00208854
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointConnectivityFilter.vtkPointConnectivityFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601740C RID: 95244
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointConnectivityFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x0601740D RID: 95245 RVA: 0x0020A674 File Offset: 0x00208874
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointConnectivityFilter.vtkPointConnectivityFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601740E RID: 95246
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointConnectivityFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x0601740F RID: 95247 RVA: 0x0020A690 File Offset: 0x00208890
		public override int IsA(string type)
		{
			return vtkPointConnectivityFilter.vtkPointConnectivityFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017410 RID: 95248
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointConnectivityFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x06017411 RID: 95249 RVA: 0x0020A6B0 File Offset: 0x002088B0
		public new static int IsTypeOf(string type)
		{
			return vtkPointConnectivityFilter.vtkPointConnectivityFilter_IsTypeOf_04(type);
		}

		// Token: 0x06017412 RID: 95250
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointConnectivityFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x06017413 RID: 95251 RVA: 0x0020A6CC File Offset: 0x002088CC
		public new vtkPointConnectivityFilter NewInstance()
		{
			vtkPointConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointConnectivityFilter.vtkPointConnectivityFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017414 RID: 95252
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointConnectivityFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information and
		/// printing.
		/// </summary>
		// Token: 0x06017415 RID: 95253 RVA: 0x0020A728 File Offset: 0x00208928
		public new static vtkPointConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointConnectivityFilter vtkPointConnectivityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointConnectivityFilter.vtkPointConnectivityFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointConnectivityFilter = (vtkPointConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointConnectivityFilter.Register(null);
				}
			}
			return vtkPointConnectivityFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A05 RID: 6661
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointConnectivityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A06 RID: 6662
		public new static readonly string MRClassNameKey = "class vtkPointConnectivityFilter";
	}
}
