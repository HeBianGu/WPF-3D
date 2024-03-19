using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000028 RID: 40
	public class vtkDICOMMRGenerator : vtkDICOMGenerator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060005D8 RID: 1496 RVA: 0x0000FC2B File Offset: 0x0000DE2B
		static vtkDICOMMRGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMMRGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMMRGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060005D9 RID: 1497 RVA: 0x0000FC53 File Offset: 0x0000DE53
		public vtkDICOMMRGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060005DA RID: 1498
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMRGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005DB RID: 1499 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public new static vtkDICOMMRGenerator New()
		{
			vtkDICOMMRGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMRGenerator.vtkDICOMMRGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMMRGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		public vtkDICOMMRGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMMRGenerator.vtkDICOMMRGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060005DD RID: 1501 RVA: 0x0000FCFC File Offset: 0x0000DEFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060005DE RID: 1502
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMMRGenerator_GenerateInstance_01(HandleRef pThis, HandleRef info);

		// Token: 0x060005DF RID: 1503 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public override bool GenerateInstance(vtkInformation info)
		{
			return vtkDICOMMRGenerator.vtkDICOMMRGenerator_GenerateInstance_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis()) != 0;
		}

		// Token: 0x060005E0 RID: 1504
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMMRGenerator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000FD44 File Offset: 0x0000DF44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMMRGenerator.vtkDICOMMRGenerator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060005E2 RID: 1506
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMMRGenerator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMMRGenerator.vtkDICOMMRGenerator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060005E4 RID: 1508
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMRGenerator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000FD80 File Offset: 0x0000DF80
		public override int IsA(string type)
		{
			return vtkDICOMMRGenerator.vtkDICOMMRGenerator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060005E6 RID: 1510
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMMRGenerator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMMRGenerator.vtkDICOMMRGenerator_IsTypeOf_05(type);
		}

		// Token: 0x060005E8 RID: 1512
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMRGenerator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000FDBC File Offset: 0x0000DFBC
		public new vtkDICOMMRGenerator NewInstance()
		{
			vtkDICOMMRGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMRGenerator.vtkDICOMMRGenerator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMMRGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005EA RID: 1514
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMMRGenerator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005EB RID: 1515 RVA: 0x0000FE18 File Offset: 0x0000E018
		public new static vtkDICOMMRGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMMRGenerator vtkDICOMMRGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMMRGenerator.vtkDICOMMRGenerator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMMRGenerator = (vtkDICOMMRGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMMRGenerator.Register(null);
				}
			}
			return vtkDICOMMRGenerator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000378 RID: 888
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMMRGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000379 RID: 889
		public new static readonly string MRClassNameKey = "class vtkDICOMMRGenerator";
	}
}
