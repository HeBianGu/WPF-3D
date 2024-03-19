using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParticlePathFilter
	/// </summary>
	/// <remarks>
	///    A Parallel Particle tracer for unsteady vector fields
	///
	/// vtkParticlePathFilter is a filter that integrates a vector field to generate particle paths
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParticlePathFilterBase has the details of the algorithms
	/// </seealso>
	// Token: 0x020004BC RID: 1212
	public class vtkParticlePathFilter : vtkParticleTracerBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DE4F RID: 56911 RVA: 0x001347AB File Offset: 0x001329AB
		static vtkParticlePathFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParticlePathFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticlePathFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE50 RID: 56912 RVA: 0x001347D3 File Offset: 0x001329D3
		public vtkParticlePathFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DE51 RID: 56913
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticlePathFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE52 RID: 56914 RVA: 0x001347E4 File Offset: 0x001329E4
		public new static vtkParticlePathFilter New()
		{
			vtkParticlePathFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticlePathFilter.vtkParticlePathFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticlePathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE53 RID: 56915 RVA: 0x00134838 File Offset: 0x00132A38
		public vtkParticlePathFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParticlePathFilter.vtkParticlePathFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE54 RID: 56916 RVA: 0x0013487C File Offset: 0x00132A7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DE55 RID: 56917
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticlePathFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE56 RID: 56918 RVA: 0x00134888 File Offset: 0x00132A88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParticlePathFilter.vtkParticlePathFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DE57 RID: 56919
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticlePathFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE58 RID: 56920 RVA: 0x001348A8 File Offset: 0x00132AA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParticlePathFilter.vtkParticlePathFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DE59 RID: 56921
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticlePathFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE5A RID: 56922 RVA: 0x001348C4 File Offset: 0x00132AC4
		public override int IsA(string type)
		{
			return vtkParticlePathFilter.vtkParticlePathFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DE5B RID: 56923
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticlePathFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE5C RID: 56924 RVA: 0x001348E4 File Offset: 0x00132AE4
		public new static int IsTypeOf(string type)
		{
			return vtkParticlePathFilter.vtkParticlePathFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600DE5D RID: 56925
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticlePathFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE5E RID: 56926 RVA: 0x00134900 File Offset: 0x00132B00
		public new vtkParticlePathFilter NewInstance()
		{
			vtkParticlePathFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticlePathFilter.vtkParticlePathFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticlePathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DE5F RID: 56927
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticlePathFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE60 RID: 56928 RVA: 0x0013495C File Offset: 0x00132B5C
		public new static vtkParticlePathFilter SafeDownCast(vtkObjectBase o)
		{
			vtkParticlePathFilter vtkParticlePathFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticlePathFilter.vtkParticlePathFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParticlePathFilter = (vtkParticlePathFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParticlePathFilter.Register(null);
				}
			}
			return vtkParticlePathFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400103F RID: 4159
		public new const string MRFullTypeName = "Kitware.VTK.vtkParticlePathFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001040 RID: 4160
		public new static readonly string MRClassNameKey = "class vtkParticlePathFilter";
	}
}
