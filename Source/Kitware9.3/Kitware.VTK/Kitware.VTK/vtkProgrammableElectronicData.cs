using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableElectronicData
	/// </summary>
	/// <remarks>
	///    Provides access to and storage of
	/// user-generated vtkImageData that describes electrons.
	/// </remarks>
	// Token: 0x02000628 RID: 1576
	public class vtkProgrammableElectronicData : vtkAbstractElectronicData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601110E RID: 69902 RVA: 0x0017C893 File Offset: 0x0017AA93
		static vtkProgrammableElectronicData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableElectronicData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableElectronicData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601110F RID: 69903 RVA: 0x0017C8BB File Offset: 0x0017AABB
		public vtkProgrammableElectronicData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011110 RID: 69904
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableElectronicData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011111 RID: 69905 RVA: 0x0017C8CC File Offset: 0x0017AACC
		public new static vtkProgrammableElectronicData New()
		{
			vtkProgrammableElectronicData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableElectronicData.vtkProgrammableElectronicData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011112 RID: 69906 RVA: 0x0017C920 File Offset: 0x0017AB20
		public vtkProgrammableElectronicData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableElectronicData.vtkProgrammableElectronicData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011113 RID: 69907 RVA: 0x0017C964 File Offset: 0x0017AB64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011114 RID: 69908
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_DeepCopy_01(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Deep copies the data object into this.
		/// </summary>
		// Token: 0x06011115 RID: 69909 RVA: 0x0017C970 File Offset: 0x0017AB70
		public override void DeepCopy(vtkDataObject obj)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_DeepCopy_01(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06011116 RID: 69910
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableElectronicData_GetElectronDensity_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the vtkImageData for the molecule's electron density.
		/// </summary>
		// Token: 0x06011117 RID: 69911 RVA: 0x0017C9A0 File Offset: 0x0017ABA0
		public override vtkImageData GetElectronDensity()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetElectronDensity_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06011118 RID: 69912
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableElectronicData_GetMO_03(HandleRef pThis, long orbitalNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the vtkImageData for the requested molecular orbital.
		/// </summary>
		// Token: 0x06011119 RID: 69913 RVA: 0x0017CA10 File Offset: 0x0017AC10
		public override vtkImageData GetMO(long orbitalNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetMO_03(base.GetCppThis(), orbitalNumber, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601111A RID: 69914
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableElectronicData_GetNumberOfElectrons_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of electrons in the molecule. Needed for HOMO/LUMO
		/// convenience functions
		/// </summary>
		// Token: 0x0601111B RID: 69915 RVA: 0x0017CA80 File Offset: 0x0017AC80
		public override long GetNumberOfElectrons()
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetNumberOfElectrons_04(base.GetCppThis());
		}

		// Token: 0x0601111C RID: 69916
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableElectronicData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601111D RID: 69917 RVA: 0x0017CAA0 File Offset: 0x0017ACA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601111E RID: 69918
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableElectronicData_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601111F RID: 69919 RVA: 0x0017CAC0 File Offset: 0x0017ACC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011120 RID: 69920
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableElectronicData_GetNumberOfMOs_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of molecular orbitals. Setting this will resize this
		/// internal array of MOs.
		/// </summary>
		// Token: 0x06011121 RID: 69921 RVA: 0x0017CADC File Offset: 0x0017ACDC
		public override long GetNumberOfMOs()
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_GetNumberOfMOs_07(base.GetCppThis());
		}

		// Token: 0x06011122 RID: 69922
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableElectronicData_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011123 RID: 69923 RVA: 0x0017CAFC File Offset: 0x0017ACFC
		public override int IsA(string type)
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06011124 RID: 69924
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableElectronicData_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011125 RID: 69925 RVA: 0x0017CB1C File Offset: 0x0017AD1C
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableElectronicData.vtkProgrammableElectronicData_IsTypeOf_09(type);
		}

		// Token: 0x06011126 RID: 69926
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableElectronicData_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011127 RID: 69927 RVA: 0x0017CB38 File Offset: 0x0017AD38
		public new vtkProgrammableElectronicData NewInstance()
		{
			vtkProgrammableElectronicData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableElectronicData.vtkProgrammableElectronicData_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011128 RID: 69928
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableElectronicData_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011129 RID: 69929 RVA: 0x0017CB94 File Offset: 0x0017AD94
		public new static vtkProgrammableElectronicData SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableElectronicData vtkProgrammableElectronicData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableElectronicData.vtkProgrammableElectronicData_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableElectronicData = (vtkProgrammableElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableElectronicData.Register(null);
				}
			}
			return vtkProgrammableElectronicData;
		}

		// Token: 0x0601112A RID: 69930
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_SetElectronDensity_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the vtkImageData for the molecule's electron density.
		/// </summary>
		// Token: 0x0601112B RID: 69931 RVA: 0x0017CC14 File Offset: 0x0017AE14
		public virtual void SetElectronDensity(vtkImageData arg0)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_SetElectronDensity_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601112C RID: 69932
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_SetMO_14(HandleRef pThis, long orbitalNumber, HandleRef data);

		/// <summary>
		/// Get/Set the vtkImageData for the requested molecular orbital.
		/// </summary>
		// Token: 0x0601112D RID: 69933 RVA: 0x0017CC44 File Offset: 0x0017AE44
		public void SetMO(long orbitalNumber, vtkImageData data)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_SetMO_14(base.GetCppThis(), orbitalNumber, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601112E RID: 69934
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_SetNumberOfElectrons_15(HandleRef pThis, long _arg);

		/// <summary>
		/// Get/Set the number of electrons in the molecule. Needed for HOMO/LUMO
		/// convenience functions
		/// </summary>
		// Token: 0x0601112F RID: 69935 RVA: 0x0017CC74 File Offset: 0x0017AE74
		public virtual void SetNumberOfElectrons(long _arg)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_SetNumberOfElectrons_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06011130 RID: 69936
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_SetNumberOfMOs_16(HandleRef pThis, long arg0);

		/// <summary>
		/// Get/Set the number of molecular orbitals. Setting this will resize this
		/// internal array of MOs.
		/// </summary>
		// Token: 0x06011131 RID: 69937 RVA: 0x0017CC84 File Offset: 0x0017AE84
		public virtual void SetNumberOfMOs(long arg0)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_SetNumberOfMOs_16(base.GetCppThis(), arg0);
		}

		// Token: 0x06011132 RID: 69938
		[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableElectronicData_SetPadding_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the padding around the molecule to which the cube extends. This
		/// is used to determine the dataset bounds.
		/// </summary>
		// Token: 0x06011133 RID: 69939 RVA: 0x0017CC94 File Offset: 0x0017AE94
		public virtual void SetPadding(double _arg)
		{
			vtkProgrammableElectronicData.vtkProgrammableElectronicData_SetPadding_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B6 RID: 5046
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableElectronicData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B7 RID: 5047
		public new static readonly string MRClassNameKey = "class vtkProgrammableElectronicData";
	}
}
