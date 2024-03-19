using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLStructuredDataWriter
	/// </summary>
	/// <remarks>
	///    Superclass for VTK XML structured data writers.
	///
	/// vtkXMLStructuredDataWriter provides VTK XML writing functionality that
	/// is common among all the structured data formats.
	/// </remarks>
	// Token: 0x020006D1 RID: 1745
	public abstract class vtkXMLStructuredDataWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601286E RID: 75886 RVA: 0x0019FC7F File Offset: 0x0019DE7F
		static vtkXMLStructuredDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601286F RID: 75887 RVA: 0x0019FCA7 File Offset: 0x0019DEA7
		public vtkXMLStructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012870 RID: 75888 RVA: 0x0019FCB5 File Offset: 0x0019DEB5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012871 RID: 75889
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataWriter_GetGhostLevel_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the ghost level used to pad each piece.
		/// </summary>
		// Token: 0x06012872 RID: 75890 RVA: 0x0019FCC0 File Offset: 0x0019DEC0
		public virtual int GetGhostLevel()
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetGhostLevel_01(base.GetCppThis());
		}

		// Token: 0x06012873 RID: 75891
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012874 RID: 75892 RVA: 0x0019FCE0 File Offset: 0x0019DEE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012875 RID: 75893
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012876 RID: 75894 RVA: 0x0019FD00 File Offset: 0x0019DF00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012877 RID: 75895
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataWriter_GetNumberOfPieces_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of pieces used to stream the image through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x06012878 RID: 75896 RVA: 0x0019FD1C File Offset: 0x0019DF1C
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetNumberOfPieces_04(base.GetCppThis());
		}

		// Token: 0x06012879 RID: 75897
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredDataWriter_GetWriteExtent_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the extent of the input that should be treated as the
		/// WholeExtent in the output file.  The default is the WholeExtent
		/// of the input.
		/// </summary>
		// Token: 0x0601287A RID: 75898 RVA: 0x0019FD3C File Offset: 0x0019DF3C
		public virtual int[] GetWriteExtent()
		{
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601287B RID: 75899
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the extent of the input that should be treated as the
		/// WholeExtent in the output file.  The default is the WholeExtent
		/// of the input.
		/// </summary>
		// Token: 0x0601287C RID: 75900 RVA: 0x0019FD84 File Offset: 0x0019DF84
		public virtual void GetWriteExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601287D RID: 75901
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the input that should be treated as the
		/// WholeExtent in the output file.  The default is the WholeExtent
		/// of the input.
		/// </summary>
		// Token: 0x0601287E RID: 75902 RVA: 0x0019FD9C File Offset: 0x0019DF9C
		public virtual void GetWriteExtent(IntPtr _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0601287F RID: 75903
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataWriter_GetWritePiece_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative, all pieces will be written.
		/// </summary>
		// Token: 0x06012880 RID: 75904 RVA: 0x0019FDAC File Offset: 0x0019DFAC
		public virtual int GetWritePiece()
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWritePiece_08(base.GetCppThis());
		}

		// Token: 0x06012881 RID: 75905
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012882 RID: 75906 RVA: 0x0019FDCC File Offset: 0x0019DFCC
		public override int IsA(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06012883 RID: 75907
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLStructuredDataWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012884 RID: 75908 RVA: 0x0019FDEC File Offset: 0x0019DFEC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_IsTypeOf_10(type);
		}

		// Token: 0x06012885 RID: 75909
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredDataWriter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012886 RID: 75910 RVA: 0x0019FE08 File Offset: 0x0019E008
		public new vtkXMLStructuredDataWriter NewInstance()
		{
			vtkXMLStructuredDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012887 RID: 75911
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLStructuredDataWriter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012888 RID: 75912 RVA: 0x0019FE64 File Offset: 0x0019E064
		public new static vtkXMLStructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredDataWriter vtkXMLStructuredDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredDataWriter = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredDataWriter.Register(null);
				}
			}
			return vtkXMLStructuredDataWriter;
		}

		// Token: 0x06012889 RID: 75913
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_SetGhostLevel_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the ghost level used to pad each piece.
		/// </summary>
		// Token: 0x0601288A RID: 75914 RVA: 0x0019FEE3 File Offset: 0x0019E0E3
		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetGhostLevel_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601288B RID: 75915
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_SetNumberOfPieces_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of pieces used to stream the image through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x0601288C RID: 75916 RVA: 0x0019FEF3 File Offset: 0x0019E0F3
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetNumberOfPieces_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0601288D RID: 75917
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_15(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the extent of the input that should be treated as the
		/// WholeExtent in the output file.  The default is the WholeExtent
		/// of the input.
		/// </summary>
		// Token: 0x0601288E RID: 75918 RVA: 0x0019FF03 File Offset: 0x0019E103
		public virtual void SetWriteExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetWriteExtent_15(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601288F RID: 75919
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the extent of the input that should be treated as the
		/// WholeExtent in the output file.  The default is the WholeExtent
		/// of the input.
		/// </summary>
		// Token: 0x06012890 RID: 75920 RVA: 0x0019FF1B File Offset: 0x0019E11B
		public virtual void SetWriteExtent(IntPtr _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetWriteExtent_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06012891 RID: 75921
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLStructuredDataWriter_SetWritePiece_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative, all pieces will be written.
		/// </summary>
		// Token: 0x06012892 RID: 75922 RVA: 0x0019FF2B File Offset: 0x0019E12B
		public virtual void SetWritePiece(int _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetWritePiece_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001553 RID: 5459
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001554 RID: 5460
		public new static readonly string MRClassNameKey = "class vtkXMLStructuredDataWriter";
	}
}
