using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkFiniteElementFieldDistributor.h
	/// </summary>
	/// <remarks>
	///  Distribute cell-centered finite element fields from the input dataset onto vtk cell
	/// points.
	///
	/// </remarks>
	// Token: 0x0200089F RID: 2207
	public class vtkFiniteElementFieldDistributor : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E9F RID: 93855 RVA: 0x002033B1 File Offset: 0x002015B1
		static vtkFiniteElementFieldDistributor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFiniteElementFieldDistributor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFiniteElementFieldDistributor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016EA0 RID: 93856 RVA: 0x002033D9 File Offset: 0x002015D9
		public vtkFiniteElementFieldDistributor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016EA1 RID: 93857
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteElementFieldDistributor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EA2 RID: 93858 RVA: 0x002033E8 File Offset: 0x002015E8
		public new static vtkFiniteElementFieldDistributor New()
		{
			vtkFiniteElementFieldDistributor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteElementFieldDistributor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EA3 RID: 93859 RVA: 0x0020343C File Offset: 0x0020163C
		public vtkFiniteElementFieldDistributor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016EA4 RID: 93860 RVA: 0x00203480 File Offset: 0x00201680
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016EA5 RID: 93861
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiniteElementFieldDistributor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EA6 RID: 93862 RVA: 0x0020348C File Offset: 0x0020168C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016EA7 RID: 93863
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFiniteElementFieldDistributor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EA8 RID: 93864 RVA: 0x002034AC File Offset: 0x002016AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016EA9 RID: 93865
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiniteElementFieldDistributor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EAA RID: 93866 RVA: 0x002034C8 File Offset: 0x002016C8
		public override int IsA(string type)
		{
			return vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016EAB RID: 93867
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFiniteElementFieldDistributor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EAC RID: 93868 RVA: 0x002034E8 File Offset: 0x002016E8
		public new static int IsTypeOf(string type)
		{
			return vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_IsTypeOf_04(type);
		}

		// Token: 0x06016EAD RID: 93869
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteElementFieldDistributor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EAE RID: 93870 RVA: 0x00203504 File Offset: 0x00201704
		public new vtkFiniteElementFieldDistributor NewInstance()
		{
			vtkFiniteElementFieldDistributor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFiniteElementFieldDistributor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016EAF RID: 93871
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFiniteElementFieldDistributor_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016EB0 RID: 93872 RVA: 0x00203560 File Offset: 0x00201760
		public new static vtkFiniteElementFieldDistributor SafeDownCast(vtkObjectBase o)
		{
			vtkFiniteElementFieldDistributor vtkFiniteElementFieldDistributor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFiniteElementFieldDistributor.vtkFiniteElementFieldDistributor_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFiniteElementFieldDistributor = (vtkFiniteElementFieldDistributor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFiniteElementFieldDistributor.Register(null);
				}
			}
			return vtkFiniteElementFieldDistributor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199F RID: 6559
		public new const string MRFullTypeName = "Kitware.VTK.vtkFiniteElementFieldDistributor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019A0 RID: 6560
		public new static readonly string MRClassNameKey = "class vtkFiniteElementFieldDistributor";
	}
}
