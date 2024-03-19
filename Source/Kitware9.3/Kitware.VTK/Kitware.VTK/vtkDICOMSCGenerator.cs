using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000026 RID: 38
	public class vtkDICOMSCGenerator : vtkDICOMGenerator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060005B0 RID: 1456 RVA: 0x0000F753 File Offset: 0x0000D953
		static vtkDICOMSCGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMSCGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSCGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060005B1 RID: 1457 RVA: 0x0000F77B File Offset: 0x0000D97B
		public vtkDICOMSCGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060005B2 RID: 1458
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSCGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000F78C File Offset: 0x0000D98C
		public new static vtkDICOMSCGenerator New()
		{
			vtkDICOMSCGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSCGenerator.vtkDICOMSCGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSCGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		public vtkDICOMSCGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMSCGenerator.vtkDICOMSCGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060005B5 RID: 1461 RVA: 0x0000F824 File Offset: 0x0000DA24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060005B6 RID: 1462
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMSCGenerator_GenerateInstance_01(HandleRef pThis, HandleRef info);

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000F830 File Offset: 0x0000DA30
		public override bool GenerateInstance(vtkInformation info)
		{
			return vtkDICOMSCGenerator.vtkDICOMSCGenerator_GenerateInstance_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis()) != 0;
		}

		// Token: 0x060005B8 RID: 1464
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSCGenerator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000F86C File Offset: 0x0000DA6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMSCGenerator.vtkDICOMSCGenerator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060005BA RID: 1466
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMSCGenerator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005BB RID: 1467 RVA: 0x0000F88C File Offset: 0x0000DA8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMSCGenerator.vtkDICOMSCGenerator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060005BC RID: 1468
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSCGenerator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005BD RID: 1469 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		public override int IsA(string type)
		{
			return vtkDICOMSCGenerator.vtkDICOMSCGenerator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060005BE RID: 1470
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMSCGenerator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005BF RID: 1471 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMSCGenerator.vtkDICOMSCGenerator_IsTypeOf_05(type);
		}

		// Token: 0x060005C0 RID: 1472
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSCGenerator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		public new vtkDICOMSCGenerator NewInstance()
		{
			vtkDICOMSCGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSCGenerator.vtkDICOMSCGenerator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMSCGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005C2 RID: 1474
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMSCGenerator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000F940 File Offset: 0x0000DB40
		public new static vtkDICOMSCGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMSCGenerator vtkDICOMSCGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMSCGenerator.vtkDICOMSCGenerator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMSCGenerator = (vtkDICOMSCGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMSCGenerator.Register(null);
				}
			}
			return vtkDICOMSCGenerator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000374 RID: 884
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSCGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000375 RID: 885
		public new static readonly string MRClassNameKey = "class vtkDICOMSCGenerator";
	}
}
