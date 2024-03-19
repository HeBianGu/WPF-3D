using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataCompressor
	/// </summary>
	/// <remarks>
	///    Abstract interface for data compression classes.
	///
	/// vtkDataCompressor provides a universal interface for data
	/// compression.  Subclasses provide one compression method and one
	/// decompression method.  The public interface to all compressors
	/// remains the same, and is defined by this class.
	///
	/// @par Note:
	/// vtkDataCompressor CompressionLevel maye take on values 1 to 9. With
	/// values of 1 giving best compression write performance, and a value of 9
	/// giving best compression ratio. Subclasses of vtkDataCompressor objects
	/// should be implemented with this in mind to provide a predictable
	/// compressor interface for vtkDataCompressor users.
	///
	/// @par Thanks:
	/// Homogeneous CompressionLevel behavior contributed by Quincy Wofford
	/// (qwofford@lanl.gov) and John Patchett (patchett@lanl.gov)
	///
	/// </remarks>
	// Token: 0x02000727 RID: 1831
	public abstract class vtkDataCompressor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601322A RID: 78378 RVA: 0x001B0CB7 File Offset: 0x001AEEB7
		static vtkDataCompressor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataCompressor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601322B RID: 78379 RVA: 0x001B0CDF File Offset: 0x001AEEDF
		public vtkDataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601322C RID: 78380 RVA: 0x001B0CED File Offset: 0x001AEEED
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601322D RID: 78381
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataCompressor_Compress_01(HandleRef pThis, IntPtr uncompressedData, ulong uncompressedSize, IntPtr compressedData, ulong compressionSpace);

		/// <summary>
		/// Compress the given input data buffer into the given output
		/// buffer.  The size of the output buffer must be at least as large
		/// as the value given by GetMaximumCompressionSpace for the given
		/// input size.
		/// </summary>
		// Token: 0x0601322E RID: 78382 RVA: 0x001B0CF8 File Offset: 0x001AEEF8
		public ulong Compress(IntPtr uncompressedData, ulong uncompressedSize, IntPtr compressedData, ulong compressionSpace)
		{
			return vtkDataCompressor.vtkDataCompressor_Compress_01(base.GetCppThis(), uncompressedData, uncompressedSize, compressedData, compressionSpace);
		}

		// Token: 0x0601322F RID: 78383
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataCompressor_Compress_02(HandleRef pThis, IntPtr uncompressedData, ulong uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Compress the given data.  A vtkUnsignedCharArray containing the
		/// compressed data is returned with a reference count of 1.
		/// </summary>
		// Token: 0x06013230 RID: 78384 RVA: 0x001B0D1C File Offset: 0x001AEF1C
		public vtkUnsignedCharArray Compress(IntPtr uncompressedData, ulong uncompressedSize)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_Compress_02(base.GetCppThis(), uncompressedData, uncompressedSize, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06013231 RID: 78385
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataCompressor_GetCompressionLevel_03(HandleRef pThis);

		/// <summary>
		///  Require level setting from any vtkDataCompressor
		///  Different compressors handle performance parameters differently
		///  vtkDataCompressors should take a value between 1 and 9
		///  where 1 is fastest compression, and 9 is best compression.
		/// </summary>
		// Token: 0x06013232 RID: 78386 RVA: 0x001B0D90 File Offset: 0x001AEF90
		public virtual int GetCompressionLevel()
		{
			return vtkDataCompressor.vtkDataCompressor_GetCompressionLevel_03(base.GetCppThis());
		}

		// Token: 0x06013233 RID: 78387
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataCompressor_GetMaximumCompressionSpace_04(HandleRef pThis, ulong size);

		/// <summary>
		/// Get the maximum space that may be needed to store data of the
		/// given uncompressed size after compression.  This is the minimum
		/// size of the output buffer that can be passed to the four-argument
		/// Compress method.
		/// </summary>
		// Token: 0x06013234 RID: 78388 RVA: 0x001B0DB0 File Offset: 0x001AEFB0
		public virtual ulong GetMaximumCompressionSpace(ulong size)
		{
			return vtkDataCompressor.vtkDataCompressor_GetMaximumCompressionSpace_04(base.GetCppThis(), size);
		}

		// Token: 0x06013235 RID: 78389
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataCompressor_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013236 RID: 78390 RVA: 0x001B0DD0 File Offset: 0x001AEFD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013237 RID: 78391
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataCompressor_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013238 RID: 78392 RVA: 0x001B0DF0 File Offset: 0x001AEFF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013239 RID: 78393
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataCompressor_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601323A RID: 78394 RVA: 0x001B0E0C File Offset: 0x001AF00C
		public override int IsA(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601323B RID: 78395
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataCompressor_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601323C RID: 78396 RVA: 0x001B0E2C File Offset: 0x001AF02C
		public new static int IsTypeOf(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_IsTypeOf_08(type);
		}

		// Token: 0x0601323D RID: 78397
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataCompressor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601323E RID: 78398 RVA: 0x001B0E48 File Offset: 0x001AF048
		public new vtkDataCompressor NewInstance()
		{
			vtkDataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601323F RID: 78399
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataCompressor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013240 RID: 78400 RVA: 0x001B0EA4 File Offset: 0x001AF0A4
		public new static vtkDataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataCompressor = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataCompressor.Register(null);
				}
			}
			return vtkDataCompressor;
		}

		// Token: 0x06013241 RID: 78401
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataCompressor_SetCompressionLevel_11(HandleRef pThis, int compressionLevel);

		/// <summary>
		///  Require level setting from any vtkDataCompressor
		///  Different compressors handle performance parameters differently
		///  vtkDataCompressors should take a value between 1 and 9
		///  where 1 is fastest compression, and 9 is best compression.
		/// </summary>
		// Token: 0x06013242 RID: 78402 RVA: 0x001B0F23 File Offset: 0x001AF123
		public virtual void SetCompressionLevel(int compressionLevel)
		{
			vtkDataCompressor.vtkDataCompressor_SetCompressionLevel_11(base.GetCppThis(), compressionLevel);
		}

		// Token: 0x06013243 RID: 78403
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataCompressor_Uncompress_12(HandleRef pThis, IntPtr compressedData, ulong compressedSize, IntPtr uncompressedData, ulong uncompressedSize);

		/// <summary>
		/// Uncompress the given input data into the given output buffer.
		/// The size of the uncompressed data must be known by the caller.
		/// It should be transmitted from the compressor by a means outside
		/// of this class.
		/// </summary>
		// Token: 0x06013244 RID: 78404 RVA: 0x001B0F34 File Offset: 0x001AF134
		public ulong Uncompress(IntPtr compressedData, ulong compressedSize, IntPtr uncompressedData, ulong uncompressedSize)
		{
			return vtkDataCompressor.vtkDataCompressor_Uncompress_12(base.GetCppThis(), compressedData, compressedSize, uncompressedData, uncompressedSize);
		}

		// Token: 0x06013245 RID: 78405
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataCompressor_Uncompress_13(HandleRef pThis, IntPtr compressedData, ulong compressedSize, ulong uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Uncompress the given data.  A vtkUnsignedCharArray containing the
		/// compressed data is returned with a reference count of 1.  The
		/// size of the uncompressed data must be known by the caller.  It
		/// should be transmitted from the compressor by a means outside of
		/// this class.
		/// </summary>
		// Token: 0x06013246 RID: 78406 RVA: 0x001B0F58 File Offset: 0x001AF158
		public vtkUnsignedCharArray Uncompress(IntPtr compressedData, ulong compressedSize, ulong uncompressedSize)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_Uncompress_13(base.GetCppThis(), compressedData, compressedSize, uncompressedSize, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161A RID: 5658
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataCompressor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161B RID: 5659
		public new static readonly string MRClassNameKey = "class vtkDataCompressor";
	}
}
