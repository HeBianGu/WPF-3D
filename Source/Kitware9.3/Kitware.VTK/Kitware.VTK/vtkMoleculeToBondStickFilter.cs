using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMoleculeToBondStickFilter
	/// </summary>
	/// <remarks>
	///    Generate polydata with cylinders
	/// representing bonds
	/// </remarks>
	// Token: 0x02000623 RID: 1571
	public class vtkMoleculeToBondStickFilter : vtkMoleculeToPolyDataFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011081 RID: 69761 RVA: 0x0017B92B File Offset: 0x00179B2B
		static vtkMoleculeToBondStickFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMoleculeToBondStickFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeToBondStickFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011082 RID: 69762 RVA: 0x0017B953 File Offset: 0x00179B53
		public vtkMoleculeToBondStickFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011083 RID: 69763
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToBondStickFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011084 RID: 69764 RVA: 0x0017B964 File Offset: 0x00179B64
		public new static vtkMoleculeToBondStickFilter New()
		{
			vtkMoleculeToBondStickFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToBondStickFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011085 RID: 69765 RVA: 0x0017B9B8 File Offset: 0x00179BB8
		public vtkMoleculeToBondStickFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011086 RID: 69766 RVA: 0x0017B9FC File Offset: 0x00179BFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011087 RID: 69767
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToBondStickFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011088 RID: 69768 RVA: 0x0017BA08 File Offset: 0x00179C08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011089 RID: 69769
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMoleculeToBondStickFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601108A RID: 69770 RVA: 0x0017BA28 File Offset: 0x00179C28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601108B RID: 69771
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToBondStickFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601108C RID: 69772 RVA: 0x0017BA44 File Offset: 0x00179C44
		public override int IsA(string type)
		{
			return vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601108D RID: 69773
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMoleculeToBondStickFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601108E RID: 69774 RVA: 0x0017BA64 File Offset: 0x00179C64
		public new static int IsTypeOf(string type)
		{
			return vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_IsTypeOf_04(type);
		}

		// Token: 0x0601108F RID: 69775
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToBondStickFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011090 RID: 69776 RVA: 0x0017BA80 File Offset: 0x00179C80
		public new vtkMoleculeToBondStickFilter NewInstance()
		{
			vtkMoleculeToBondStickFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMoleculeToBondStickFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011091 RID: 69777
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMoleculeToBondStickFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011092 RID: 69778 RVA: 0x0017BADC File Offset: 0x00179CDC
		public new static vtkMoleculeToBondStickFilter SafeDownCast(vtkObjectBase o)
		{
			vtkMoleculeToBondStickFilter vtkMoleculeToBondStickFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMoleculeToBondStickFilter.vtkMoleculeToBondStickFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMoleculeToBondStickFilter = (vtkMoleculeToBondStickFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMoleculeToBondStickFilter.Register(null);
				}
			}
			return vtkMoleculeToBondStickFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013AC RID: 5036
		public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeToBondStickFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013AD RID: 5037
		public new static readonly string MRClassNameKey = "class vtkMoleculeToBondStickFilter";
	}
}
