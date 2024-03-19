using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphWeightEuclideanDistanceFilter
	/// </summary>
	/// <remarks>
	///    Weights the edges of a
	/// graph based on the Euclidean distance between the points.
	///
	///
	/// Weights the edges of a graph based on the Euclidean distance between the points.
	/// </remarks>
	// Token: 0x020008A6 RID: 2214
	public class vtkGraphWeightEuclideanDistanceFilter : vtkGraphWeightFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F6A RID: 94058 RVA: 0x002043B7 File Offset: 0x002025B7
		static vtkGraphWeightEuclideanDistanceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphWeightEuclideanDistanceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphWeightEuclideanDistanceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F6B RID: 94059 RVA: 0x002043DF File Offset: 0x002025DF
		public vtkGraphWeightEuclideanDistanceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016F6C RID: 94060
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphWeightEuclideanDistanceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F6D RID: 94061 RVA: 0x002043F0 File Offset: 0x002025F0
		public new static vtkGraphWeightEuclideanDistanceFilter New()
		{
			vtkGraphWeightEuclideanDistanceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphWeightEuclideanDistanceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F6E RID: 94062 RVA: 0x00204444 File Offset: 0x00202644
		public vtkGraphWeightEuclideanDistanceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016F6F RID: 94063 RVA: 0x00204488 File Offset: 0x00202688
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016F70 RID: 94064
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphWeightEuclideanDistanceFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F71 RID: 94065 RVA: 0x00204494 File Offset: 0x00202694
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016F72 RID: 94066
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphWeightEuclideanDistanceFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F73 RID: 94067 RVA: 0x002044B4 File Offset: 0x002026B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016F74 RID: 94068
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphWeightEuclideanDistanceFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F75 RID: 94069 RVA: 0x002044D0 File Offset: 0x002026D0
		public override int IsA(string type)
		{
			return vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016F76 RID: 94070
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphWeightEuclideanDistanceFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F77 RID: 94071 RVA: 0x002044F0 File Offset: 0x002026F0
		public new static int IsTypeOf(string type)
		{
			return vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_IsTypeOf_04(type);
		}

		// Token: 0x06016F78 RID: 94072
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphWeightEuclideanDistanceFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F79 RID: 94073 RVA: 0x0020450C File Offset: 0x0020270C
		public new vtkGraphWeightEuclideanDistanceFilter NewInstance()
		{
			vtkGraphWeightEuclideanDistanceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphWeightEuclideanDistanceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016F7A RID: 94074
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphWeightEuclideanDistanceFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F7B RID: 94075 RVA: 0x00204568 File Offset: 0x00202768
		public new static vtkGraphWeightEuclideanDistanceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGraphWeightEuclideanDistanceFilter vtkGraphWeightEuclideanDistanceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphWeightEuclideanDistanceFilter.vtkGraphWeightEuclideanDistanceFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphWeightEuclideanDistanceFilter = (vtkGraphWeightEuclideanDistanceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphWeightEuclideanDistanceFilter.Register(null);
				}
			}
			return vtkGraphWeightEuclideanDistanceFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B2 RID: 6578
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphWeightEuclideanDistanceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B3 RID: 6579
		public new static readonly string MRClassNameKey = "class vtkGraphWeightEuclideanDistanceFilter";
	}
}
