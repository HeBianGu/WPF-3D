using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLUnstructuredDataWriter
	/// </summary>
	/// <remarks>
	///    Superclass for VTK XML unstructured data writers.
	///
	/// vtkXMLUnstructuredDataWriter provides VTK XML writing functionality
	/// that is common among all the unstructured data formats.
	/// </remarks>
	// Token: 0x020006E1 RID: 1761
	public abstract class vtkXMLUnstructuredDataWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060129DA RID: 76250 RVA: 0x001A26F7 File Offset: 0x001A08F7
		static vtkXMLUnstructuredDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060129DB RID: 76251 RVA: 0x001A271F File Offset: 0x001A091F
		public vtkXMLUnstructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060129DC RID: 76252 RVA: 0x001A272D File Offset: 0x001A092D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060129DD RID: 76253
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataWriter_GetGhostLevel_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the ghost level used to pad each piece.
		/// </summary>
		// Token: 0x060129DE RID: 76254 RVA: 0x001A2738 File Offset: 0x001A0938
		public virtual int GetGhostLevel()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetGhostLevel_01(base.GetCppThis());
		}

		// Token: 0x060129DF RID: 76255
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129E0 RID: 76256 RVA: 0x001A2758 File Offset: 0x001A0958
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060129E1 RID: 76257
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129E2 RID: 76258 RVA: 0x001A2778 File Offset: 0x001A0978
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060129E3 RID: 76259
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataWriter_GetNumberOfPieces_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of pieces used to stream the image through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x060129E4 RID: 76260 RVA: 0x001A2794 File Offset: 0x001A0994
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetNumberOfPieces_04(base.GetCppThis());
		}

		// Token: 0x060129E5 RID: 76261
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataWriter_GetWritePiece_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative or equal to the NumberOfPieces, all pieces will be written.
		/// </summary>
		// Token: 0x060129E6 RID: 76262 RVA: 0x001A27B4 File Offset: 0x001A09B4
		public virtual int GetWritePiece()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetWritePiece_05(base.GetCppThis());
		}

		// Token: 0x060129E7 RID: 76263
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129E8 RID: 76264 RVA: 0x001A27D4 File Offset: 0x001A09D4
		public override int IsA(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060129E9 RID: 76265
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLUnstructuredDataWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129EA RID: 76266 RVA: 0x001A27F4 File Offset: 0x001A09F4
		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_IsTypeOf_07(type);
		}

		// Token: 0x060129EB RID: 76267
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129EC RID: 76268 RVA: 0x001A2810 File Offset: 0x001A0A10
		public new vtkXMLUnstructuredDataWriter NewInstance()
		{
			vtkXMLUnstructuredDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060129ED RID: 76269
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLUnstructuredDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129EE RID: 76270 RVA: 0x001A286C File Offset: 0x001A0A6C
		public new static vtkXMLUnstructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredDataWriter vtkXMLUnstructuredDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredDataWriter = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredDataWriter.Register(null);
				}
			}
			return vtkXMLUnstructuredDataWriter;
		}

		// Token: 0x060129EF RID: 76271
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUnstructuredDataWriter_SetGhostLevel_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the ghost level used to pad each piece.
		/// </summary>
		// Token: 0x060129F0 RID: 76272 RVA: 0x001A28EB File Offset: 0x001A0AEB
		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetGhostLevel_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060129F1 RID: 76273
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUnstructuredDataWriter_SetNumberOfPieces_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of pieces used to stream the image through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x060129F2 RID: 76274 RVA: 0x001A28FB File Offset: 0x001A0AFB
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetNumberOfPieces_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060129F3 RID: 76275
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLUnstructuredDataWriter_SetWritePiece_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative or equal to the NumberOfPieces, all pieces will be written.
		/// </summary>
		// Token: 0x060129F4 RID: 76276 RVA: 0x001A290B File Offset: 0x001A0B0B
		public virtual void SetWritePiece(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetWritePiece_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001573 RID: 5491
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001574 RID: 5492
		public new static readonly string MRClassNameKey = "class vtkXMLUnstructuredDataWriter";
	}
}
