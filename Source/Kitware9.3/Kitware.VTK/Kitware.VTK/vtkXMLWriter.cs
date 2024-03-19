using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLWriter
	/// </summary>
	/// <remarks>
	///    Superclass for VTK's XML file writers.
	///
	/// vtkXMLWriter provides methods implementing most of the
	/// functionality needed to write VTK XML file formats.  Concrete
	/// subclasses provide actual writer implementations calling upon this
	/// functionality.
	///
	/// @par Thanks
	/// CompressionLevel getters/setters exposed by Quincy Wofford
	/// (qwofford@lanl.gov) and John Patchett (patchett@lanl.gov),
	/// Los Alamos National Laboratory (2017)
	/// </remarks>
	// Token: 0x0200013A RID: 314
	public abstract class vtkXMLWriter : vtkXMLWriterBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003DF2 RID: 15858 RVA: 0x0005A629 File Offset: 0x00058829
		static vtkXMLWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003DF3 RID: 15859 RVA: 0x0005A651 File Offset: 0x00058851
		public vtkXMLWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003DF4 RID: 15860 RVA: 0x0005A65F File Offset: 0x0005885F
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003DF5 RID: 15861
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter_GetInput_01(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003DF6 RID: 15862 RVA: 0x0005A66C File Offset: 0x0005886C
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetInput_01(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06003DF7 RID: 15863
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003DF8 RID: 15864 RVA: 0x0005A6DC File Offset: 0x000588DC
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06003DF9 RID: 15865
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DFA RID: 15866 RVA: 0x0005A74C File Offset: 0x0005894C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003DFB RID: 15867
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003DFC RID: 15868 RVA: 0x0005A76C File Offset: 0x0005896C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003DFD RID: 15869
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter_GetNumberOfTimeSteps_05(HandleRef pThis);

		/// <summary>
		/// Set the number of time steps
		/// </summary>
		// Token: 0x06003DFE RID: 15870 RVA: 0x0005A788 File Offset: 0x00058988
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkXMLWriter.vtkXMLWriter_GetNumberOfTimeSteps_05(base.GetCppThis());
		}

		// Token: 0x06003DFF RID: 15871
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E00 RID: 15872 RVA: 0x0005A7A8 File Offset: 0x000589A8
		public override int IsA(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06003E01 RID: 15873
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E02 RID: 15874 RVA: 0x0005A7C8 File Offset: 0x000589C8
		public new static int IsTypeOf(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_IsTypeOf_07(type);
		}

		// Token: 0x06003E03 RID: 15875
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E04 RID: 15876 RVA: 0x0005A7E4 File Offset: 0x000589E4
		public new vtkXMLWriter NewInstance()
		{
			vtkXMLWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003E05 RID: 15877
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003E06 RID: 15878 RVA: 0x0005A840 File Offset: 0x00058A40
		public new static vtkXMLWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLWriter vtkXMLWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriter = (vtkXMLWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriter.Register(null);
				}
			}
			return vtkXMLWriter;
		}

		// Token: 0x06003E07 RID: 15879
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_SetInputData_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003E08 RID: 15880 RVA: 0x0005A8C0 File Offset: 0x00058AC0
		public void SetInputData(vtkDataObject arg0)
		{
			vtkXMLWriter.vtkXMLWriter_SetInputData_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003E09 RID: 15881
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_SetInputData_11(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06003E0A RID: 15882 RVA: 0x0005A8F0 File Offset: 0x00058AF0
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkXMLWriter.vtkXMLWriter_SetInputData_11(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06003E0B RID: 15883
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_SetNumberOfTimeSteps_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of time steps
		/// </summary>
		// Token: 0x06003E0C RID: 15884 RVA: 0x0005A920 File Offset: 0x00058B20
		public virtual void SetNumberOfTimeSteps(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetNumberOfTimeSteps_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06003E0D RID: 15885
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_Start_13(HandleRef pThis);

		/// <summary>
		/// API to interface an outside the VTK pipeline control
		/// </summary>
		// Token: 0x06003E0E RID: 15886 RVA: 0x0005A930 File Offset: 0x00058B30
		public void Start()
		{
			vtkXMLWriter.vtkXMLWriter_Start_13(base.GetCppThis());
		}

		// Token: 0x06003E0F RID: 15887
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_Stop_14(HandleRef pThis);

		/// <summary>
		/// API to interface an outside the VTK pipeline control
		/// </summary>
		// Token: 0x06003E10 RID: 15888 RVA: 0x0005A93F File Offset: 0x00058B3F
		public void Stop()
		{
			vtkXMLWriter.vtkXMLWriter_Stop_14(base.GetCppThis());
		}

		// Token: 0x06003E11 RID: 15889
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLWriter_WriteNextTime_15(HandleRef pThis, double time);

		/// <summary>
		/// API to interface an outside the VTK pipeline control
		/// </summary>
		// Token: 0x06003E12 RID: 15890 RVA: 0x0005A94E File Offset: 0x00058B4E
		public void WriteNextTime(double time)
		{
			vtkXMLWriter.vtkXMLWriter_WriteNextTime_15(base.GetCppThis(), time);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006B8 RID: 1720
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006B9 RID: 1721
		public new static readonly string MRClassNameKey = "class vtkXMLWriter";
	}
}
