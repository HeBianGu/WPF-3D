using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredPointsWriter
	/// </summary>
	/// <remarks>
	///    write vtk structured points data file
	///
	/// vtkStructuredPointsWriter is a source object that writes ASCII or binary
	/// structured points data in vtk file format. See text for format details.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	// Token: 0x02000715 RID: 1813
	public class vtkStructuredPointsWriter : vtkDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601301A RID: 77850 RVA: 0x001AD59B File Offset: 0x001AB79B
		static vtkStructuredPointsWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601301B RID: 77851 RVA: 0x001AD5C3 File Offset: 0x001AB7C3
		public vtkStructuredPointsWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601301C RID: 77852
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601301D RID: 77853 RVA: 0x001AD5D4 File Offset: 0x001AB7D4
		public new static vtkStructuredPointsWriter New()
		{
			vtkStructuredPointsWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsWriter.vtkStructuredPointsWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601301E RID: 77854 RVA: 0x001AD628 File Offset: 0x001AB828
		public vtkStructuredPointsWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredPointsWriter.vtkStructuredPointsWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601301F RID: 77855 RVA: 0x001AD66C File Offset: 0x001AB86C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013020 RID: 77856
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06013021 RID: 77857 RVA: 0x001AD678 File Offset: 0x001AB878
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsWriter.vtkStructuredPointsWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013022 RID: 77858
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06013023 RID: 77859 RVA: 0x001AD6E8 File Offset: 0x001AB8E8
		public new vtkImageData GetInput(int port)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsWriter.vtkStructuredPointsWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06013024 RID: 77860
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013025 RID: 77861 RVA: 0x001AD758 File Offset: 0x001AB958
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredPointsWriter.vtkStructuredPointsWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013026 RID: 77862
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013027 RID: 77863 RVA: 0x001AD778 File Offset: 0x001AB978
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredPointsWriter.vtkStructuredPointsWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013028 RID: 77864
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredPointsWriter_GetWriteExtent_05(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06013029 RID: 77865 RVA: 0x001AD794 File Offset: 0x001AB994
		public virtual bool GetWriteExtent()
		{
			return vtkStructuredPointsWriter.vtkStructuredPointsWriter_GetWriteExtent_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601302A RID: 77866
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601302B RID: 77867 RVA: 0x001AD7BC File Offset: 0x001AB9BC
		public override int IsA(string type)
		{
			return vtkStructuredPointsWriter.vtkStructuredPointsWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601302C RID: 77868
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601302D RID: 77869 RVA: 0x001AD7DC File Offset: 0x001AB9DC
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsWriter.vtkStructuredPointsWriter_IsTypeOf_07(type);
		}

		// Token: 0x0601302E RID: 77870
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601302F RID: 77871 RVA: 0x001AD7F8 File Offset: 0x001AB9F8
		public new vtkStructuredPointsWriter NewInstance()
		{
			vtkStructuredPointsWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsWriter.vtkStructuredPointsWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013030 RID: 77872
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013031 RID: 77873 RVA: 0x001AD854 File Offset: 0x001ABA54
		public new static vtkStructuredPointsWriter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsWriter vtkStructuredPointsWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsWriter.vtkStructuredPointsWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsWriter = (vtkStructuredPointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsWriter.Register(null);
				}
			}
			return vtkStructuredPointsWriter;
		}

		// Token: 0x06013032 RID: 77874
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredPointsWriter_SetWriteExtent_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06013033 RID: 77875 RVA: 0x001AD8D3 File Offset: 0x001ABAD3
		public virtual void SetWriteExtent(bool _arg)
		{
			vtkStructuredPointsWriter.vtkStructuredPointsWriter_SetWriteExtent_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06013034 RID: 77876
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredPointsWriter_WriteExtentOff_12(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06013035 RID: 77877 RVA: 0x001AD8EB File Offset: 0x001ABAEB
		public virtual void WriteExtentOff()
		{
			vtkStructuredPointsWriter.vtkStructuredPointsWriter_WriteExtentOff_12(base.GetCppThis());
		}

		// Token: 0x06013036 RID: 77878
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredPointsWriter_WriteExtentOn_13(HandleRef pThis);

		/// <summary>
		/// When WriteExtent is on, vtkStructuredPointsWriter writes
		/// data extent in the output file. Otherwise, it writes dimensions.
		/// The only time this option is useful is when the extents do
		/// not start at (0, 0, 0). This is an options to support writing
		/// of older formats while still using a newer VTK.
		/// </summary>
		// Token: 0x06013037 RID: 77879 RVA: 0x001AD8FA File Offset: 0x001ABAFA
		public virtual void WriteExtentOn()
		{
			vtkStructuredPointsWriter.vtkStructuredPointsWriter_WriteExtentOn_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F6 RID: 5622
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015F7 RID: 5623
		public new static readonly string MRClassNameKey = "class vtkStructuredPointsWriter";
	}
}
