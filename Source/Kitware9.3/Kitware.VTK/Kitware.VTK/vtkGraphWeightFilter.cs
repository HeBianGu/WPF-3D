using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphWeightFilter
	/// </summary>
	/// <remarks>
	///    Base class for filters that weight graph
	/// edges.
	///
	///
	/// vtkGraphWeightFilter is the abstract base class that provides an interface
	/// for classes that apply weights to graph edges. The weights are added
	/// as a vtkFloatArray named "Weights."
	/// The ComputeWeight function must be implemented to provide the function of two
	/// vertices which determines the weight of each edge.
	/// The CheckRequirements function can be implemented if you wish to ensure
	/// that the input graph has all of the properties that will be required
	/// by the ComputeWeight function.
	/// </remarks>
	// Token: 0x020008A5 RID: 2213
	public abstract class vtkGraphWeightFilter : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016F5B RID: 94043 RVA: 0x00204223 File Offset: 0x00202423
		static vtkGraphWeightFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphWeightFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphWeightFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016F5C RID: 94044 RVA: 0x0020424B File Offset: 0x0020244B
		public vtkGraphWeightFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016F5D RID: 94045 RVA: 0x00204259 File Offset: 0x00202459
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016F5E RID: 94046
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphWeightFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F5F RID: 94047 RVA: 0x00204264 File Offset: 0x00202464
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphWeightFilter.vtkGraphWeightFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016F60 RID: 94048
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphWeightFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F61 RID: 94049 RVA: 0x00204284 File Offset: 0x00202484
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphWeightFilter.vtkGraphWeightFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016F62 RID: 94050
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphWeightFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F63 RID: 94051 RVA: 0x002042A0 File Offset: 0x002024A0
		public override int IsA(string type)
		{
			return vtkGraphWeightFilter.vtkGraphWeightFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016F64 RID: 94052
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphWeightFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F65 RID: 94053 RVA: 0x002042C0 File Offset: 0x002024C0
		public new static int IsTypeOf(string type)
		{
			return vtkGraphWeightFilter.vtkGraphWeightFilter_IsTypeOf_04(type);
		}

		// Token: 0x06016F66 RID: 94054
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphWeightFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F67 RID: 94055 RVA: 0x002042DC File Offset: 0x002024DC
		public new vtkGraphWeightFilter NewInstance()
		{
			vtkGraphWeightFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphWeightFilter.vtkGraphWeightFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphWeightFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016F68 RID: 94056
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphWeightFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016F69 RID: 94057 RVA: 0x00204338 File Offset: 0x00202538
		public new static vtkGraphWeightFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGraphWeightFilter vtkGraphWeightFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphWeightFilter.vtkGraphWeightFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphWeightFilter = (vtkGraphWeightFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphWeightFilter.Register(null);
				}
			}
			return vtkGraphWeightFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B0 RID: 6576
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphWeightFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B1 RID: 6577
		public new static readonly string MRClassNameKey = "class vtkGraphWeightFilter";
	}
}
