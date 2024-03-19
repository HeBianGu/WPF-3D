using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractParticleWriter
	/// </summary>
	/// <remarks>
	///    abstract class to write particle data to file
	///
	/// vtkAbstractParticleWriter is an abstract class which is used by
	/// vtkParticleTracerBase to write particles out during simulations.
	/// This class is abstract and provides a TimeStep and FileName.
	/// Subclasses of this should provide the necessary IO.
	///
	/// @warning
	/// See vtkWriter
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParticleTracerBase
	/// </seealso>
	// Token: 0x0200071B RID: 1819
	public abstract class vtkAbstractParticleWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060130AE RID: 77998 RVA: 0x001AE927 File Offset: 0x001ACB27
		static vtkAbstractParticleWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractParticleWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractParticleWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060130AF RID: 77999 RVA: 0x001AE94F File Offset: 0x001ACB4F
		public vtkAbstractParticleWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060130B0 RID: 78000 RVA: 0x001AE95D File Offset: 0x001ACB5D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060130B1 RID: 78001
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_CloseFile_01(HandleRef pThis);

		/// <summary>
		/// Close the file after a write. This is optional but
		/// may protect against data loss in between steps
		/// </summary>
		// Token: 0x060130B2 RID: 78002 RVA: 0x001AE968 File Offset: 0x001ACB68
		public virtual void CloseFile()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_CloseFile_01(base.GetCppThis());
		}

		// Token: 0x060130B3 RID: 78003
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractParticleWriter_GetCollectiveIO_02(HandleRef pThis);

		/// <summary>
		/// When running in parallel, this writer may be capable of
		/// Collective IO operations (HDF5). By default, this is off.
		/// </summary>
		// Token: 0x060130B4 RID: 78004 RVA: 0x001AE978 File Offset: 0x001ACB78
		public virtual int GetCollectiveIO()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetCollectiveIO_02(base.GetCppThis());
		}

		// Token: 0x060130B5 RID: 78005
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractParticleWriter_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Set/get the FileName that is being written to
		/// </summary>
		// Token: 0x060130B6 RID: 78006 RVA: 0x001AE998 File Offset: 0x001ACB98
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060130B7 RID: 78007
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractParticleWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130B8 RID: 78008 RVA: 0x001AE9D4 File Offset: 0x001ACBD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060130B9 RID: 78009
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractParticleWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130BA RID: 78010 RVA: 0x001AE9F4 File Offset: 0x001ACBF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060130BB RID: 78011
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractParticleWriter_GetTimeStep_06(HandleRef pThis);

		/// <summary>
		/// Set/get the TimeStep that is being written
		/// </summary>
		// Token: 0x060130BC RID: 78012 RVA: 0x001AEA10 File Offset: 0x001ACC10
		public virtual int GetTimeStep()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetTimeStep_06(base.GetCppThis());
		}

		// Token: 0x060130BD RID: 78013
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractParticleWriter_GetTimeValue_07(HandleRef pThis);

		/// <summary>
		/// Before writing the current data out, set the TimeValue (optional)
		/// The TimeValue is a float/double value that corresponds to the real
		/// time of the data, it may not be regular, whereas the TimeSteps
		/// are simple increments.
		/// </summary>
		// Token: 0x060130BE RID: 78014 RVA: 0x001AEA30 File Offset: 0x001ACC30
		public virtual double GetTimeValue()
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_GetTimeValue_07(base.GetCppThis());
		}

		// Token: 0x060130BF RID: 78015
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractParticleWriter_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130C0 RID: 78016 RVA: 0x001AEA50 File Offset: 0x001ACC50
		public override int IsA(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060130C1 RID: 78017
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractParticleWriter_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130C2 RID: 78018 RVA: 0x001AEA70 File Offset: 0x001ACC70
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractParticleWriter.vtkAbstractParticleWriter_IsTypeOf_09(type);
		}

		// Token: 0x060130C3 RID: 78019
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractParticleWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130C4 RID: 78020 RVA: 0x001AEA8C File Offset: 0x001ACC8C
		public new vtkAbstractParticleWriter NewInstance()
		{
			vtkAbstractParticleWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractParticleWriter.vtkAbstractParticleWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060130C5 RID: 78021
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractParticleWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130C6 RID: 78022 RVA: 0x001AEAE8 File Offset: 0x001ACCE8
		public new static vtkAbstractParticleWriter SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractParticleWriter vtkAbstractParticleWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractParticleWriter.vtkAbstractParticleWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractParticleWriter = (vtkAbstractParticleWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractParticleWriter.Register(null);
				}
			}
			return vtkAbstractParticleWriter;
		}

		// Token: 0x060130C7 RID: 78023
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetCollectiveIO_12(HandleRef pThis, int _arg);

		/// <summary>
		/// When running in parallel, this writer may be capable of
		/// Collective IO operations (HDF5). By default, this is off.
		/// </summary>
		// Token: 0x060130C8 RID: 78024 RVA: 0x001AEB67 File Offset: 0x001ACD67
		public virtual void SetCollectiveIO(int _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetCollectiveIO_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060130C9 RID: 78025
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the FileName that is being written to
		/// </summary>
		// Token: 0x060130CA RID: 78026 RVA: 0x001AEB77 File Offset: 0x001ACD77
		public virtual void SetFileName(string _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetFileName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060130CB RID: 78027
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetTimeStep_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the TimeStep that is being written
		/// </summary>
		// Token: 0x060130CC RID: 78028 RVA: 0x001AEB87 File Offset: 0x001ACD87
		public virtual void SetTimeStep(int _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetTimeStep_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060130CD RID: 78029
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetTimeValue_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Before writing the current data out, set the TimeValue (optional)
		/// The TimeValue is a float/double value that corresponds to the real
		/// time of the data, it may not be regular, whereas the TimeSteps
		/// are simple increments.
		/// </summary>
		// Token: 0x060130CE RID: 78030 RVA: 0x001AEB97 File Offset: 0x001ACD97
		public virtual void SetTimeValue(double _arg)
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetTimeValue_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060130CF RID: 78031
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetWriteModeToCollective_16(HandleRef pThis);

		/// <summary>
		/// When running in parallel, this writer may be capable of
		/// Collective IO operations (HDF5). By default, this is off.
		/// </summary>
		// Token: 0x060130D0 RID: 78032 RVA: 0x001AEBA7 File Offset: 0x001ACDA7
		public void SetWriteModeToCollective()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetWriteModeToCollective_16(base.GetCppThis());
		}

		// Token: 0x060130D1 RID: 78033
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractParticleWriter_SetWriteModeToIndependent_17(HandleRef pThis);

		/// <summary>
		/// When running in parallel, this writer may be capable of
		/// Collective IO operations (HDF5). By default, this is off.
		/// </summary>
		// Token: 0x060130D2 RID: 78034 RVA: 0x001AEBB6 File Offset: 0x001ACDB6
		public void SetWriteModeToIndependent()
		{
			vtkAbstractParticleWriter.vtkAbstractParticleWriter_SetWriteModeToIndependent_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001602 RID: 5634
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractParticleWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001603 RID: 5635
		public new static readonly string MRClassNameKey = "class vtkAbstractParticleWriter";
	}
}
