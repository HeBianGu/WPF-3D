using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInterpolatingSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    generate a subdivision surface using an Interpolating Scheme
	///
	/// vtkInterpolatingSubdivisionFilter is an abstract class that defines
	/// the protocol for interpolating subdivision surface filters.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearSubdivisionFilter vtkButterflySubdivisionFilter
	/// </seealso>
	// Token: 0x02000549 RID: 1353
	public abstract class vtkInterpolatingSubdivisionFilter : vtkSubdivisionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F106 RID: 61702 RVA: 0x0014FC43 File Offset: 0x0014DE43
		static vtkInterpolatingSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolatingSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolatingSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F107 RID: 61703 RVA: 0x0014FC6B File Offset: 0x0014DE6B
		public vtkInterpolatingSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F108 RID: 61704 RVA: 0x0014FC79 File Offset: 0x0014DE79
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F109 RID: 61705
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolatingSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F10A RID: 61706 RVA: 0x0014FC84 File Offset: 0x0014DE84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F10B RID: 61707
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolatingSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F10C RID: 61708 RVA: 0x0014FCA4 File Offset: 0x0014DEA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F10D RID: 61709
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolatingSubdivisionFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F10E RID: 61710 RVA: 0x0014FCC0 File Offset: 0x0014DEC0
		public override int IsA(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F10F RID: 61711
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolatingSubdivisionFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F110 RID: 61712 RVA: 0x0014FCE0 File Offset: 0x0014DEE0
		public new static int IsTypeOf(string type)
		{
			return vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600F111 RID: 61713
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolatingSubdivisionFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F112 RID: 61714 RVA: 0x0014FCFC File Offset: 0x0014DEFC
		public new vtkInterpolatingSubdivisionFilter NewInstance()
		{
			vtkInterpolatingSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F113 RID: 61715
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolatingSubdivisionFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F114 RID: 61716 RVA: 0x0014FD58 File Offset: 0x0014DF58
		public new static vtkInterpolatingSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolatingSubdivisionFilter vtkInterpolatingSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolatingSubdivisionFilter.vtkInterpolatingSubdivisionFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolatingSubdivisionFilter = (vtkInterpolatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolatingSubdivisionFilter.Register(null);
				}
			}
			return vtkInterpolatingSubdivisionFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118A RID: 4490
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolatingSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400118B RID: 4491
		public new static readonly string MRClassNameKey = "class vtkInterpolatingSubdivisionFilter";
	}
}
