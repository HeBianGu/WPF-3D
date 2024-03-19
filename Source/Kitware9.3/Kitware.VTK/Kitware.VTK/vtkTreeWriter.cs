using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeWriter
	/// </summary>
	/// <remarks>
	///    write vtkTree data to a file
	///
	/// vtkTreeWriter is a sink object that writes ASCII or binary
	/// vtkTree data files in vtk format. See text for format details.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	// Token: 0x02000718 RID: 1816
	public class vtkTreeWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013068 RID: 77928 RVA: 0x001ADF8F File Offset: 0x001AC18F
		static vtkTreeWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013069 RID: 77929 RVA: 0x001ADFB7 File Offset: 0x001AC1B7
		public vtkTreeWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601306A RID: 77930
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601306B RID: 77931 RVA: 0x001ADFC8 File Offset: 0x001AC1C8
		public new static vtkTreeWriter New()
		{
			vtkTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeWriter.vtkTreeWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601306C RID: 77932 RVA: 0x001AE01C File Offset: 0x001AC21C
		public vtkTreeWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeWriter.vtkTreeWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601306D RID: 77933 RVA: 0x001AE060 File Offset: 0x001AC260
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601306E RID: 77934
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x0601306F RID: 77935 RVA: 0x001AE06C File Offset: 0x001AC26C
		public new vtkTree GetInput()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeWriter.vtkTreeWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06013070 RID: 77936
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06013071 RID: 77937 RVA: 0x001AE0DC File Offset: 0x001AC2DC
		public new vtkTree GetInput(int port)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeWriter.vtkTreeWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06013072 RID: 77938
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013073 RID: 77939 RVA: 0x001AE14C File Offset: 0x001AC34C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeWriter.vtkTreeWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013074 RID: 77940
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013075 RID: 77941 RVA: 0x001AE16C File Offset: 0x001AC36C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeWriter.vtkTreeWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013076 RID: 77942
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013077 RID: 77943 RVA: 0x001AE188 File Offset: 0x001AC388
		public override int IsA(string type)
		{
			return vtkTreeWriter.vtkTreeWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06013078 RID: 77944
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013079 RID: 77945 RVA: 0x001AE1A8 File Offset: 0x001AC3A8
		public new static int IsTypeOf(string type)
		{
			return vtkTreeWriter.vtkTreeWriter_IsTypeOf_06(type);
		}

		// Token: 0x0601307A RID: 77946
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601307B RID: 77947 RVA: 0x001AE1C4 File Offset: 0x001AC3C4
		public new vtkTreeWriter NewInstance()
		{
			vtkTreeWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeWriter.vtkTreeWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601307C RID: 77948
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601307D RID: 77949 RVA: 0x001AE220 File Offset: 0x001AC420
		public new static vtkTreeWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTreeWriter vtkTreeWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeWriter.vtkTreeWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeWriter = (vtkTreeWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeWriter.Register(null);
				}
			}
			return vtkTreeWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FC RID: 5628
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015FD RID: 5629
		public new static readonly string MRClassNameKey = "class vtkTreeWriter";
	}
}
