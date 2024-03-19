using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLZMADataCompressor
	/// </summary>
	/// <remarks>
	///    Data compression using LZMA Utils.
	///
	/// vtkLZMADataCompressor provides a concrete vtkDataCompressor class
	/// using LZMA for compressing and uncompressing data.
	///
	/// @par Thanks:
	/// This vtkDataCompressor contributed by Quincy Wofford (qwofford@lanl.gov)
	/// and John Patchett (patchett@lanl.gov), Los Alamos National Laboratory
	/// (2017)
	///
	/// </remarks>
	// Token: 0x0200072F RID: 1839
	public class vtkLZMADataCompressor : vtkDataCompressor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013310 RID: 78608 RVA: 0x001B22C7 File Offset: 0x001B04C7
		static vtkLZMADataCompressor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLZMADataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLZMADataCompressor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013311 RID: 78609 RVA: 0x001B22EF File Offset: 0x001B04EF
		public vtkLZMADataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013312 RID: 78610
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZMADataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013313 RID: 78611 RVA: 0x001B2300 File Offset: 0x001B0500
		public new static vtkLZMADataCompressor New()
		{
			vtkLZMADataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZMADataCompressor.vtkLZMADataCompressor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013314 RID: 78612 RVA: 0x001B2354 File Offset: 0x001B0554
		public vtkLZMADataCompressor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLZMADataCompressor.vtkLZMADataCompressor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013315 RID: 78613 RVA: 0x001B2398 File Offset: 0x001B0598
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013316 RID: 78614
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZMADataCompressor_GetCompressionLevel_01(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x06013317 RID: 78615 RVA: 0x001B23A4 File Offset: 0x001B05A4
		public override int GetCompressionLevel()
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_GetCompressionLevel_01(base.GetCppThis());
		}

		// Token: 0x06013318 RID: 78616
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLZMADataCompressor_GetMaximumCompressionSpace_02(HandleRef pThis, ulong size);

		/// <summary>
		///  Get the maximum space that may be needed to store data of the
		///  given uncompressed size after compression.  This is the minimum
		///  size of the output buffer that can be passed to the four-argument
		///  Compress method.
		/// </summary>
		// Token: 0x06013319 RID: 78617 RVA: 0x001B23C4 File Offset: 0x001B05C4
		public override ulong GetMaximumCompressionSpace(ulong size)
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_GetMaximumCompressionSpace_02(base.GetCppThis(), size);
		}

		// Token: 0x0601331A RID: 78618
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLZMADataCompressor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601331B RID: 78619 RVA: 0x001B23E4 File Offset: 0x001B05E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601331C RID: 78620
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLZMADataCompressor_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601331D RID: 78621 RVA: 0x001B2404 File Offset: 0x001B0604
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601331E RID: 78622
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZMADataCompressor_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601331F RID: 78623 RVA: 0x001B2420 File Offset: 0x001B0620
		public override int IsA(string type)
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06013320 RID: 78624
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZMADataCompressor_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013321 RID: 78625 RVA: 0x001B2440 File Offset: 0x001B0640
		public new static int IsTypeOf(string type)
		{
			return vtkLZMADataCompressor.vtkLZMADataCompressor_IsTypeOf_06(type);
		}

		// Token: 0x06013322 RID: 78626
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZMADataCompressor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013323 RID: 78627 RVA: 0x001B245C File Offset: 0x001B065C
		public new vtkLZMADataCompressor NewInstance()
		{
			vtkLZMADataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZMADataCompressor.vtkLZMADataCompressor_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013324 RID: 78628
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZMADataCompressor_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013325 RID: 78629 RVA: 0x001B24B8 File Offset: 0x001B06B8
		public new static vtkLZMADataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkLZMADataCompressor vtkLZMADataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZMADataCompressor.vtkLZMADataCompressor_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLZMADataCompressor = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLZMADataCompressor.Register(null);
				}
			}
			return vtkLZMADataCompressor;
		}

		// Token: 0x06013326 RID: 78630
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLZMADataCompressor_SetCompressionLevel_10(HandleRef pThis, int compressionLevel);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x06013327 RID: 78631 RVA: 0x001B2537 File Offset: 0x001B0737
		public override void SetCompressionLevel(int compressionLevel)
		{
			vtkLZMADataCompressor.vtkLZMADataCompressor_SetCompressionLevel_10(base.GetCppThis(), compressionLevel);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162C RID: 5676
		public new const string MRFullTypeName = "Kitware.VTK.vtkLZMADataCompressor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162D RID: 5677
		public new static readonly string MRClassNameKey = "class vtkLZMADataCompressor";
	}
}
