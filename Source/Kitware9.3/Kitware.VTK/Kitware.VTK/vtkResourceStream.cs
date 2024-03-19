using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  Abstract class used for custom streams
	///
	/// vtkResourceStream provides a high-level interface for manipulating
	/// custom streams. This class is designed to be used instead of "SetFileName"
	/// and "SetInputString" or similar that exists in most of reader or reader-like
	/// classes in VTK.
	///
	/// vtkResourceStream only support unformatted input, user must use external
	/// solution to format the input, such as sscanf or scnlib, fast_float or strtoX
	///
	/// vtkResourceStream **may** be support seeking, code that uses
	/// vtkResourceStream should take in account this, and support for both seekable
	/// stream and not seekable streams, if possible. `stream.SupportSeek()` can be
	/// used for support checking.
	/// </remarks>
	// Token: 0x02000729 RID: 1833
	public abstract class vtkResourceStream : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013275 RID: 78453 RVA: 0x001B13D5 File Offset: 0x001AF5D5
		static vtkResourceStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResourceStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResourceStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013276 RID: 78454 RVA: 0x001B13FD File Offset: 0x001AF5FD
		public vtkResourceStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013277 RID: 78455 RVA: 0x001B140B File Offset: 0x001AF60B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013278 RID: 78456
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResourceStream_EndOfStream_01(HandleRef pThis);

		/// <summary>
		/// @brief Check if the stream reached an end.
		///
		/// The stream may be out of range (EOF) if a Seek call move before stream
		/// begin (0), or after stream end (max) Seek on an EndOfStream stream may
		/// restore it back to a valid state. Read on an invalid stream must do
		/// nothing and return 0.
		///
		/// @return Return true if the stream reached the end of input, false
		/// otherwise.
		/// </summary>
		// Token: 0x06013279 RID: 78457 RVA: 0x001B1418 File Offset: 0x001AF618
		public virtual bool EndOfStream()
		{
			return vtkResourceStream.vtkResourceStream_EndOfStream_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0601327A RID: 78458
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601327B RID: 78459 RVA: 0x001B1440 File Offset: 0x001AF640
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResourceStream.vtkResourceStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601327C RID: 78460
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601327D RID: 78461 RVA: 0x001B1460 File Offset: 0x001AF660
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResourceStream.vtkResourceStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601327E RID: 78462
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResourceStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601327F RID: 78463 RVA: 0x001B147C File Offset: 0x001AF67C
		public override int IsA(string type)
		{
			return vtkResourceStream.vtkResourceStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013280 RID: 78464
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResourceStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013281 RID: 78465 RVA: 0x001B149C File Offset: 0x001AF69C
		public new static int IsTypeOf(string type)
		{
			return vtkResourceStream.vtkResourceStream_IsTypeOf_05(type);
		}

		// Token: 0x06013282 RID: 78466
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResourceStream_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013283 RID: 78467 RVA: 0x001B14B8 File Offset: 0x001AF6B8
		public new vtkResourceStream NewInstance()
		{
			vtkResourceStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResourceStream.vtkResourceStream_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013284 RID: 78468
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkResourceStream_Read_07(HandleRef pThis, IntPtr buffer, ulong bytes);

		/// <summary>
		/// @brief Read data form the stream
		///
		/// Read at most `bytes` bytes from input stream.
		/// If this function reads less that `bytes` bytes, then EndOfStream must
		/// return true.
		///
		/// @param buffer User provided storage buffer, may be nullptr if bytes == 0
		/// @param bytes Maximum amount of bytes to read.
		/// @return The number of bytes read, may be 0.
		/// </summary>
		// Token: 0x06013285 RID: 78469 RVA: 0x001B1514 File Offset: 0x001AF714
		public virtual ulong Read(IntPtr buffer, ulong bytes)
		{
			return vtkResourceStream.vtkResourceStream_Read_07(base.GetCppThis(), buffer, bytes);
		}

		// Token: 0x06013286 RID: 78470
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResourceStream_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013287 RID: 78471 RVA: 0x001B1538 File Offset: 0x001AF738
		public new static vtkResourceStream SafeDownCast(vtkObjectBase o)
		{
			vtkResourceStream vtkResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResourceStream.vtkResourceStream_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResourceStream = (vtkResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResourceStream.Register(null);
				}
			}
			return vtkResourceStream;
		}

		// Token: 0x06013288 RID: 78472
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceStream_Seek_09(HandleRef pThis, long pos, vtkResourceStream.SeekDirection dir);

		/// <summary>
		/// @brief Move the stream cursor position
		///
		/// Base version does nothing and returns 0.
		/// This function does not check if the position is out of range.
		/// EndOfFile() result must only change after a call of Read with
		/// non-zero size.
		///
		/// @return Current position in stream.
		/// </summary>
		// Token: 0x06013289 RID: 78473 RVA: 0x001B15B8 File Offset: 0x001AF7B8
		public virtual long Seek(long pos, vtkResourceStream.SeekDirection dir)
		{
			return vtkResourceStream.vtkResourceStream_Seek_09(base.GetCppThis(), pos, dir);
		}

		// Token: 0x0601328A RID: 78474
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkResourceStream_SupportSeek_10(HandleRef pThis);

		/// <summary>
		/// @brief Check if stream supports Seek and Tell functions
		///
		/// @return true if Seek and Tell functions are supported.
		/// </summary>
		// Token: 0x0601328B RID: 78475 RVA: 0x001B15DC File Offset: 0x001AF7DC
		public bool SupportSeek()
		{
			return vtkResourceStream.vtkResourceStream_SupportSeek_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601328C RID: 78476
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResourceStream_Tell_11(HandleRef pThis);

		/// <summary>
		/// @brief Get the stream cursor position
		///
		/// Base version calls `Seek(0, std::ios_base::cur)`.
		/// If seeking is unsupported, return 0.
		/// Subclasses may reimplement it to provide a more efficient version.
		///
		/// @return Current position in stream.
		/// </summary>
		// Token: 0x0601328D RID: 78477 RVA: 0x001B1604 File Offset: 0x001AF804
		public virtual long Tell()
		{
			return vtkResourceStream.vtkResourceStream_Tell_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161E RID: 5662
		public new const string MRFullTypeName = "Kitware.VTK.vtkResourceStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400161F RID: 5663
		public new static readonly string MRClassNameKey = "class vtkResourceStream";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200072A RID: 1834
		public enum SeekDirection
		{
			/// <summary>enum member</summary>
			// Token: 0x04001621 RID: 5665
			Begin,
			/// <summary>enum member</summary>
			// Token: 0x04001622 RID: 5666
			Current,
			/// <summary>enum member</summary>
			// Token: 0x04001623 RID: 5667
			End
		}
	}
}
