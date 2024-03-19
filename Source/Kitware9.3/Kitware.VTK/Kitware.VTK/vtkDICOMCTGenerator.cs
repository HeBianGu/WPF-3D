using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000027 RID: 39
	public class vtkDICOMCTGenerator : vtkDICOMGenerator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060005C4 RID: 1476 RVA: 0x0000F9BF File Offset: 0x0000DBBF
		static vtkDICOMCTGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMCTGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCTGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060005C5 RID: 1477 RVA: 0x0000F9E7 File Offset: 0x0000DBE7
		public vtkDICOMCTGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060005C6 RID: 1478
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		public new static vtkDICOMCTGenerator New()
		{
			vtkDICOMCTGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTGenerator.vtkDICOMCTGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCTGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000FA4C File Offset: 0x0000DC4C
		public vtkDICOMCTGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMCTGenerator.vtkDICOMCTGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060005C9 RID: 1481 RVA: 0x0000FA90 File Offset: 0x0000DC90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060005CA RID: 1482
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDICOMCTGenerator_GenerateInstance_01(HandleRef pThis, HandleRef info);

		// Token: 0x060005CB RID: 1483 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		public override bool GenerateInstance(vtkInformation info)
		{
			return vtkDICOMCTGenerator.vtkDICOMCTGenerator_GenerateInstance_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis()) != 0;
		}

		// Token: 0x060005CC RID: 1484
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCTGenerator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005CD RID: 1485 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMCTGenerator.vtkDICOMCTGenerator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060005CE RID: 1486
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCTGenerator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005CF RID: 1487 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMCTGenerator.vtkDICOMCTGenerator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060005D0 RID: 1488
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTGenerator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public override int IsA(string type)
		{
			return vtkDICOMCTGenerator.vtkDICOMCTGenerator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060005D2 RID: 1490
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTGenerator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000FB34 File Offset: 0x0000DD34
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMCTGenerator.vtkDICOMCTGenerator_IsTypeOf_05(type);
		}

		// Token: 0x060005D4 RID: 1492
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTGenerator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000FB50 File Offset: 0x0000DD50
		public new vtkDICOMCTGenerator NewInstance()
		{
			vtkDICOMCTGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTGenerator.vtkDICOMCTGenerator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCTGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060005D6 RID: 1494
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTGenerator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		public new static vtkDICOMCTGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMCTGenerator vtkDICOMCTGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTGenerator.vtkDICOMCTGenerator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMCTGenerator = (vtkDICOMCTGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMCTGenerator.Register(null);
				}
			}
			return vtkDICOMCTGenerator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000376 RID: 886
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCTGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000377 RID: 887
		public new static readonly string MRClassNameKey = "class vtkDICOMCTGenerator";
	}
}
